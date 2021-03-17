using ZooManagement.Models.Database;
using System.Collections.Generic;

namespace ZooManagement.Data
{
    public static class SampleAnimalTypes
    {
        public static int NumberOfAnimalTypes = 20;

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
                Alias = "Blue Poison Dart Frog"
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
                Alias = "Moon Jellyfish"
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
            }   
        };
        public static IEnumerable<AnimalType> GetAnimalTypes()
        {
            return _animaltypes;
        }
    }
}