using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagement.Models.Database {

    public class Enclosure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EnclosureName { get; set; }
        public int MaxCapacity { get; set; } 
        public ICollection<AnimalType> AnimalTypes { get; set; }
    }
}