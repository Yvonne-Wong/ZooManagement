using ZooManagement.Models.Database;
using System.Collections.Generic;
using System;

using System.Linq;
using ZooManagement.Models.Request;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace ZooManagement.Data
{
    public static class SampleAnimalTypes
    {
        private static List<Enclosure> _enclosures = SampleEnclosures.GetEnclosures();
        // private static List<AnimalType> _animaltypes = new List<AnimalType>
        public static List<AnimalType> GetAnimalTypes(ZooManagementDbContext context)
        {
            List<AnimalType> animaltypes = new List<AnimalType>
            {
                new AnimalType
                {
                    Id = 1,
                    Class = "Mammal",
                    Family = "Canidae",
                    Genus = "Canis",
                    Species = "C. lupus",
                    Alias = "Wolf",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[0].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 2,
                    Class = "Amphibian",
                    Family = "Dendrobatidae",
                    Genus = "Dendrobates",
                    Species = "D. tinctorius",
                    Alias = "Blue poison dart frog",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[1].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 3,
                    Class = "Bird",
                    Family = "Psittacidae",
                    Genus = "Psittacus",
                    Species = "P. erithacus",
                    Alias = "African grey parrot",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[2].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 4,
                    Class = "Bird",
                    Family = "Cacatuidae",
                    Genus = "Cacatua",
                    Species = "C. alba",
                    Alias = "Umbrella cockatoo",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[3].Item2).ToList()
                },
                new AnimalType 
                {
                    Id = 5,
                    Class = "Fish",
                    Family = "Pomacentridae",
                    Genus = "Amphiprion",
                    Species = "Amphiprion ocellaris",
                    Alias = "Clownfish",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[4].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 6,
                    Class = "Fish",
                    Family = "Acanthuridae",
                    Genus = "Paracanthurus",
                    Species = "P. hepatus",
                    Alias = "Blue tang",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[5].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 7,
                    Class = "Mammal",
                    Family = "Caviidae",
                    Genus = "Hydrochoerus",
                    Species = "H. hydrochaeris",
                    Alias = "Capybara",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[6].Item2).ToList()
                }, 
                new AnimalType
                {
                    Id = 8,
                    Class = "Invertebrate",
                    Family = "Ulmaridae",
                    Genus = "Aurelia",
                    Species = "A. aurita",
                    Alias = "Moon jellyfish",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[7].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 9,
                    Class = "Mammal",
                    Family = "Ursidae",
                    Genus = "Ailuropoda",
                    Species = "A. melanoleuca",
                    Alias = "Panda",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[8].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 10,
                    Class = "Reptile",
                    Family = "Eublepharidae",
                    Genus = "Eublepharis",
                    Species = "E. macularius",
                    Alias = "Leopard gecko",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[9].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 11,
                    Class = "Mammal",
                    Family = "Elephantidae",
                    Genus = "Loxodonta",
                    Species = "L. africana",
                    Alias = "African bush elephant",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[10].Item2).ToList()
                },   
                new AnimalType
                {
                    Id = 12,
                    Class = "Amphibian",
                    Family = "Amphiumidae",
                    Genus = "Salamandridae",
                    Species = "Ambystoma maculatum",
                    Alias = "Asiatic salamander",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[11].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 13,
                    Class = "Mammal",
                    Family = "Giraffidae",
                    Genus = "Giraffa",
                    Species = "G. camelopardalis",
                    Alias = "Giraffe",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[12].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 14,
                    Class = "Mammal",
                    Family = "Felidae",
                    Genus = "Panthera",
                    Species = "P. tigris",
                    Alias = "Tiger",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[13].Item2).ToList()
                },
                new AnimalType
                { 
                    Id = 15,
                    Class = "Mammal",
                    Family = "Felidae",
                    Genus = "Panthera",
                    Species = "P. leo",
                    Alias = "Lion",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[14].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 16,
                    Class = "Bird",
                    Family = "Spheniscidae",
                    Genus = "Aptenodytes",
                    Species = "	A. forsteri",
                    Alias = "Emperor penguin",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[15].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 17,
                    Class = "Mammal",
                    Family = "Ursidae",
                    Genus = "Helarctos",
                    Species = "H. malayanus",
                    Alias = "Sun bear",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[16].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 18,
                    Class = "Mammal",
                    Family = "Equidae",
                    Genus = "Equus",
                    Species = "E. quagga",
                    Alias = "Common zebra",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[17].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 19,
                    Class = "Reptile",
                    Family = "Testudinidae",
                    Genus = "Chelonoidis",
                    Species = "C. n. complex",
                    Alias = "Galapagos tortoise",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[18].Item2).ToList()
                },
                new AnimalType
                { 
                    Id = 20,
                    Class = "Mammal",
                    Family = "Bradypodidae",
                    Genus = "Bradypus",
                    Species = "B. variegatus",
                    Alias = "Three-toed sloth",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[19].Item2).ToList()
                },
                new AnimalType
                {
                    Id = 21,
                    Class = "Mammal",
                    Family = "Hippopotamidae",
                    Genus = "Hippopotamus",
                    Species = "H. amphibius",
                    Alias = "Hippopotamus",
                    Enclosures = context.Enclosures.Where(e => e.Id == _animaltypeenclosures[20].Item2).ToList()
                }
            };
            return animaltypes;
        }

        private static List<(int AnimalTypeId, int EnclosureId)> _animaltypeenclosures = new List<(int AnimalTypeId, int EnclosureId)>
        {
            (1, 10),
            (2, 4),
            (3, 2),
            (4, 2),
            (5, 6),
            (6, 6), 
            (7, 10),
            (8, 6),
            (9, 9),
            (10, 4),
            (11, 8),
            (12, 4),
            (13, 5),
            (14, 1),
            (15, 8),
            (16, 7),
            (17, 9),
            (18, 8),
            (19, 4),
            (20, 10),
            (21, 3)
        };

        public static List<(int AnimalTypeId, int EnclosureId)> GetAnimalTypeEnclosure()
        {
            return _animaltypeenclosures;
        }
    }
}