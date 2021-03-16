
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagement.Models.Database {

    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Sex { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime AcquirementDate { get; set; }

        public string Family { get; set; }

        public string Genus { get; set; }
        
        public string Species {get; set; }
        
    }
}