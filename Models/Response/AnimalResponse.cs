using ZooManagement.Models.Database;
using System;

namespace ZooManagement.Models.Response
{
    public class AnimalResponse
    {
        private readonly Animal _animal;
        public AnimalResponse(Animal animal)
        {
            _animal = animal;
        }

        public int Id => _animal.Id;

        public string Name => _animal.Name;

        public bool Sex => _animal.Sex;

        public DateTime Birthday => _animal.DateOfBirth.Date;

        public DateTime AcquirementDate => _animal.AcquirementDate.Date;

        public string Class => _animal.AnimalType.Class;        

        public string Family => _animal.AnimalType.Family;

        public string Genus => _animal.AnimalType.Genus;

        public string Species => _animal.AnimalType.Species;

        public string Alias => _animal.AnimalType.Alias;
    }
}