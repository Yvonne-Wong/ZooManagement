using ZooManagement.Models.Database;
using System.Collections.Generic;

namespace ZooManagement.Data
{
    public static class SampleEnclosures
    {
        private static List<Enclosure> _enclosures = new List<Enclosure>
        {
            new Enclosure
            {
                Id = 1,
                EnclosureName = "Tiger House",
                MaxCapacity = 10
            },
            new Enclosure
            {
                Id = 2,
                EnclosureName = "Aviary",
                MaxCapacity = 50
            },
            new Enclosure 
            {
                Id = 3,
                EnclosureName = "Hippo House",
                MaxCapacity = 10
            },
            new Enclosure
            {
                Id = 4,
                EnclosureName = "Reptile House",
                MaxCapacity = 40
            },
            new Enclosure
            {
                Id = 5,
                EnclosureName = "Giraffe House",
                MaxCapacity = 6
            },
            new Enclosure
            {
                Id = 6,
                EnclosureName = "Aquarium",
                MaxCapacity = 20
            },
            new Enclosure
            {
                Id = 7,
                EnclosureName = "Penguin Pool",
                MaxCapacity =  15,

            },
            new Enclosure 
            {
                Id = 8,
                EnclosureName = "Little Africa",
                MaxCapacity = 30
            },
            new Enclosure
            {
                Id = 9,
                EnclosureName = "The Bear Hut",
                MaxCapacity = 10
            },
            new Enclosure
            {
                Id = 10,
                EnclosureName = "The Forest",
                MaxCapacity = 20
            }
    
        };
        public static IEnumerable<Enclosure> GetEnclosures()
        {
            return _enclosures;
        }
    }
}