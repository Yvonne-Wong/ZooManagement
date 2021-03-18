using ZooManagement.Models.Database;
using System.Collections.Generic;

namespace ZooManagement.Data
{
    public static class SampleAnimalTypes
    {
        private static List<AnimalType> _animaltypes = new List<AnimalType>
        {
            new AnimalType
            {
                Id = 1,
                Class = "Mammal",
                Family = "Canidae",
                Genus = "Canis",
                Species = "C. lupus",
                Alias = "Wolf"
            },
            new AnimalType
            {
                Id = 2,
                Class = "Amphibian",
                Family = "Dendrobatidae",
                Genus = "Dendrobates",
                Species = "D. tinctorius",
                Alias = "Blue poison dart frog"
            },
            new AnimalType
            {
                Id = 3,
                Class = "Bird",
                Family = "Psittacidae",
                Genus = "Psittacus",
                Species = "P. erithacus",
                Alias = "African grey parrot"
            },
            new AnimalType
            {
                Id = 4,
                Class = "Bird",
                Family = "Cacatuidae",
                Genus = "Cacatua",
                Species = "C. alba",
                Alias = "Umbrella cockatoo"
            },
            new AnimalType 
            {
                Id = 5,
                Class = "Fish",
                Family = "Pomacentridae",
                Genus = "Amphiprion",
                Species = "Amphiprion ocellaris",
                Alias = "Clownfish"
            },
            new AnimalType
            {
                Id = 6,
                Class = "Fish",
                Family = "Acanthuridae",
                Genus = "Paracanthurus",
                Species = "P. hepatus",
                Alias = "Blue tang"
            },
            new AnimalType
            {
                Id = 7,
                Class = "Mammal",
                Family = "Caviidae",
                Genus = "Hydrochoerus",
                Species = "H. hydrochaeris",
                Alias = "Capybara"

            }, 
            new AnimalType
            {
                Id = 8,
                Class = "Invertebrate",
                Family = "Ulmaridae",
                Genus = "Aurelia",
                Species = "A. aurita",
                Alias = "Moon jellyfish"
            },
            new AnimalType
            {
                Id = 9,
                Class = "Mammal",
                Family = "Ursidae",
                Genus = "Ailuropoda",
                Species = "A. melanoleuca",
                Alias = "Panda"
            },
            new AnimalType
            {
                Id = 10,
                Class = "Reptile",
                Family = "Eublepharidae",
                Genus = "Eublepharis",
                Species = "E. macularius",
                Alias = "Leopard gecko"
            },
            new AnimalType
            {
                Id = 11,
                Class = "Mammal",
                Family = "Elephantidae",
                Genus = "Loxodonta",
                Species = "L. africana",
                Alias = "African bush elephant" 
            },   
            new AnimalType
            {
                Id = 12,
                Class = "Amphibian",
                Family = "Amphiumidae",
                Genus = "Salamandridae",
                Species = "Ambystoma maculatum",
                Alias = "Asiatic salamander"
            },
            new AnimalType
            {
                Id = 13,
                Class = "Mammal",
                Family = "Giraffidae",
                Genus = "Giraffa",
                Species = "G. camelopardalis",
                Alias = "Giraffe"
            },
            new AnimalType
            {
                Id = 14,
                Class = "Mammal",
                Family = "Felidae",
                Genus = "Panthera",
                Species = "P. tigris",
                Alias = "Tiger"
            },
            new AnimalType
            { 
                Id = 15,
                Class = "Mammal",
                Family = "Felidae",
                Genus = "Panthera",
                Species = "P. leo",
                Alias = "Lion"
            },
            new AnimalType
            {
                Id = 16,
                Class = "Bird",
                Family = "Spheniscidae",
                Genus = "Aptenodytes",
                Species = "	A. forsteri",
                Alias = "Emperor penguin"
            },
            new AnimalType
            {
                Id = 17,
                Class = "Mammal",
                Family = "Ursidae",
                Genus = "Helarctos",
                Species = "H. malayanus",
                Alias = "Sun bear"
            },
            new AnimalType
            {
                Id = 18,
                Class = "Mammal",
                Family = "Equidae",
                Genus = "Equus",
                Species = "E. quagga",
                Alias = "Common zebra"
            },
            new AnimalType
            {
                Id = 19,
                Class = "Reptile",
                Family = "Testudinidae",
                Genus = "Chelonoidis",
                Species = "C. n. complex",
                Alias = "Galapagos tortoise"
            },
            new AnimalType
            { 
                Id = 20,
                Class = "Mammal",
                Family = "Bradypodidae",
                Genus = "Bradypus",
                Species = "B. variegatus",
                Alias = "Three-toed sloth"
            }
        };
        public static IEnumerable<AnimalType> GetAnimalTypes()
        {
            return _animaltypes;
        }
    }
}