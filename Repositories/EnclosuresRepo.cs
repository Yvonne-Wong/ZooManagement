using System.Collections.Generic;
using System;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Models.Request;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace ZooManagement.Repositories
{
    public interface IEnclosuresRepo
    {
        bool EnclosureCanTakeAnimal(int enclosureId, int animalTypeId);
    }

    public class EnclosuresRepo : IEnclosuresRepo
    {
        private readonly ZooManagementDbContext _context;

        public EnclosuresRepo(ZooManagementDbContext context)
        {
            _context = context;
        }

        public bool EnclosureCanTakeAnimal(int enclosureId, int animalTypeId)
        {
            var enclosure = _context.Enclosures.Where(e => e.Id == enclosureId).Single();
            var animalType = _context.AnimalTypes.Where(a => a.Id == animalTypeId).Single();
            if (enclosure.AnimalTypes.Contains(animalType))
            {
                return true;
            }
            else 
            {
                return false;
            }            
        }
    }
}