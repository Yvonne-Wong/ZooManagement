using System.ComponentModel.DataAnnotations;
using System;
using ZooManagement.Models.Database;

namespace ZooManagement.Models.Request
{
    public class AddAnimalRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public DateTime AcquirementDate { get; set; }

        [Required]
        public int AnimalTypeId { get; set; }
        [Required]
        public int EnclosureId { get; set; }
    }
}