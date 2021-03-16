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

        public string Family => _animal.Family;

        public string Genus => _animal.Genus;

        public string Species => _animal.Species;
    }
}