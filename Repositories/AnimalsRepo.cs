using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Models.Request;
using ZooManagement.Models.Response;

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
                Class = newAnimal.Class,
                Family = newAnimal.Family,
                Genus = newAnimal.Genus,
                Species = newAnimal.Species,
                Alias = newAnimal.Alias          
            });
            _context.SaveChanges();
            return insertResponse.Entity;
        }

         public IEnumerable<Animal> Search(AnimalSearchRequest search)
        {
            return _context.Animals
                .Where(p => search.Search == null || 
                            (
                                p.Name.ToLower().Contains(search.Search) ||
                                p.Alias.ToLower().Contains(search.Search) ||
                                p.Class.ToLower().Contains(search.Search) ||
                                p.Genus.ToLower().Contains(search.Search) ||
                                p.Species.ToLower().Contains(search.Search) ||
                                p.Family.ToLower().Contains(search.Search) 
                            ))
                .OrderBy(a => a.Class)
                .Skip((search.Page - 1) * search.PageSize)
                .Take(search.PageSize);
        }

        public int Count(AnimalSearchRequest search)
        {
            return _context.Animals
                .Count(p => search.Search == null || 
                            (
                                p.Name.ToLower().Contains(search.Search) ||
                                p.Class.ToLower().Contains(search.Search) ||
                                p.Family.ToLower().Contains(search.Search) ||
                                p.Genus.ToLower().Contains(search.Search) ||
                                p.Species.ToLower().Contains(search.Search) ||
                                p.Alias.ToLower().Contains(search.Search)
                            ));
        }
    }
}