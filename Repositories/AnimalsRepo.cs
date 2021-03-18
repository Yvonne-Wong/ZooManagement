using System.Collections.Generic;
using System;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Models.Request;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace ZooManagement.Repositories
{
    public interface IAnimalsRepo
    {
        Animal GetById(int id);
        Animal Add(AddAnimalRequest newAnimal);
        IEnumerable<Animal> Search(AnimalSearchRequest search);
        int Count(AnimalSearchRequest search);
    }

    public class AnimalsRepo : IAnimalsRepo
    {
        private readonly ZooManagementDbContext _context;

        public AnimalsRepo(ZooManagementDbContext context)
        {
            _context = context;
        }

        public Animal GetById(int id)
        {
            return _context.Animals
                .Include(animal => animal.AnimalType)
                .Single(animal => animal.Id == id);
        }

        public Animal Add(AddAnimalRequest newAnimal)
        {
            var insertResponse = _context.Animals.Add(new Animal
            {
                Name = newAnimal.Name,
                Sex = newAnimal.Sex,
                DateOfBirth = newAnimal.DateOfBirth,   
                AcquirementDate = newAnimal.AcquirementDate,
                AnimalTypeId = newAnimal.AnimalTypeId,         
            });
            _context.SaveChanges();
            return insertResponse.Entity;
        }
        public IEnumerable<Animal> Search(AnimalSearchRequest search)
        {
            // int CalculateAge(DateTime birthday)
            // {
            //     // DateTime birthday = DateOfBirth;
            //     int age = DateTime.Today.Year - birthday.Year;
            //     if (birthday.Date > DateTime.Today.AddYears(-age)) { age--; }
            //     return age;
            // }  
            string sortColumn = "Id";
            if (!String.IsNullOrEmpty(search.Order)) 
            {
                switch (search.Order.ToLower())
                {
                    case "name":
                        sortColumn = "Name";
                        break;
                    case "age":
                        sortColumn = "DateOfBirth";
                        break;
                    // case "species":
                    //     // .OrderBy(a => a.AnimalType.Alias)
                    //     break;
                    default:
                        sortColumn = "Id";
                        break;
                }
            }

            DateTime? AcquiredDateToSearch = search.DateAcquired == null ? null : DateTime.Parse(search.DateAcquired);

            return _context.Animals
                .Include(a => a.AnimalType)
                .Where(a => search.Search == null || 
                            (
                                (search.Name == null || a.Name.ToLower().Contains(search.Name)) &&
                                (search.Age == null || (a.DateOfBirth > DateTime.Today.AddYears(a.DateOfBirth.Year - DateTime.Today.Year) ? DateTime.Today.Year - a.DateOfBirth.Year - 1 : DateTime.Today.Year - a.DateOfBirth.Year) == search.Age) &&
                                (search.DateAcquired == null || a.AcquirementDate == AcquiredDateToSearch) &&
                                (search.Class == null || a.AnimalType.Class.ToLower().Contains(search.Class)) &&
                                (search.Alias == null || a.AnimalType.Alias.ToLower().Contains(search.Alias)) 
                            ))
                .OrderBy(a => EF.Property<object>(a, sortColumn))
                .Skip((search.Page - 1) * search.PageSize)
                .Take(search.PageSize);
        }

        public int Count(AnimalSearchRequest search)
        {
            return _context.Animals
                .Include(a => a.AnimalType)
                .Count(a => search.Search == null || 
                            (
                                (search.Name == null || a.Name.ToLower().Contains(search.Name)) &&
                                (search.Age == null || (a.DateOfBirth > DateTime.Today.AddYears(a.DateOfBirth.Year - DateTime.Today.Year) ? DateTime.Today.Year - a.DateOfBirth.Year - 1 : DateTime.Today.Year - a.DateOfBirth.Year) == search.Age) &&
                                (search.Class == null || a.AnimalType.Class.ToLower().Contains(search.Class)) &&
                                (search.Alias == null || a.AnimalType.Alias.ToLower().Contains(search.Alias)) 
                            ));
        }
    }
}