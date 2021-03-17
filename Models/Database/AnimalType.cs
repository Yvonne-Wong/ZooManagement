using System;
using System.Collections.Generic;

namespace ZooManagement.Models.Database
{
    public class AnimalType 
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }        
        public string Species {get; set; }
        public string Alias { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}