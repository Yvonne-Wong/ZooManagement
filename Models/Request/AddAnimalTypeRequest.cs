using System.ComponentModel.DataAnnotations;
using System;
using ZooManagement.Models.Database;
using System.Collections.Generic;

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

        [Required]
        public List<int> EnclosureIds { get; set; }


    }
}