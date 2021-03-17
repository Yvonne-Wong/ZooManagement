using System.ComponentModel.DataAnnotations;
using System;
using ZooManagement.Models.Database;

namespace ZooManagement.Models.Request
{
    public class AddAnimalTypeRequest
    {
        [Required]
        public string Class { get; set;}

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