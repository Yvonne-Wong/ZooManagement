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
        public int AnimalTypeId { get; set; }
        public AnimalType AnimalType { get; set; }   
        public int EnclosureId { get; set; }
        public Enclosure Enclosure { get; set; }
    }
}