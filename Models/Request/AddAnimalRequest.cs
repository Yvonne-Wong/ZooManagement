using System.ComponentModel.DataAnnotations;
using System;

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
        public string Class { get; set; }

        [Required]
        public string Family { get; set; }

        [Required]
        public string Genus { get; set; }

        [Required]
        public string Species { get; set; }

        [Required]
        public string Alias { get; set; }
    }
}