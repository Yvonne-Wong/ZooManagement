using ZooManagement.Models.Database;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ZooManagement.Data
{
    public static class SampleAnimals
    {
        public static int NumberOfAnimals = 100;
        private static IEnumerable<AnimalType> _animaltypes = SampleAnimalTypes.GetAnimalTypes();

        private static List<string> _names = new List<string>
        {
            "Kiki",
            "Mooney",
            "Boris",
            "Timmy",
            "Pete",
            "Nova",
            "Kit",
            "Asa",
            "Onyx",
            "Neo",
            "Lux",
            "Jules",
            "Fallon",
            "Jericho",
            "Scout",
            "Florian",
            "Bowie",
            "Indigo",
            "Bingo",
            "Biscuit",
            "Bailey",
            "Avery",
            "Angel",
            "Boomer",
            "Chunk",
            "Chewie",
            "Coco",
            "Cuddles",
            "Dakota",
            "Domino",
            "Dot",
            "Echo",
            "Emery",
            "Espresso",
            "Fluffy",
            "Frankie",
            "Freckles",
            "Frosty",
            "Fuzzy",
            "Gizmo",
            "Gouda",
            "Harley",
            "Happy",
            "Harper",
            "Hershey",
            "Ivory",
            "Jazz",
            "Kai",
            "Kibbles",
            "Laika",
            "Link",
            "Lucky",
            "Maple",
            "Micah",
            "Muffin",
            "Munchkin",
            "Nacho",
            "Nugget",
            "Oakley",
            "Oreo",
            "Patches",
            "Paws",
            "Peanut",
            "Peewee",
            "Pepper",
            "Pinky",
            "Pistachio",
            "Pookie",
            "Pumpkin",
            "Raisin",
            "Rebel",
            "Reese",
            "Rory",
            "Sage",
            "Sandy",
            "Scrappy",
            "Shadow",
            "Shaggy",
            "Sky",
            "Snowball",
            "Spot",
            "Stinky",
            "Squirt",
            "Sunny",
            "Twix",
            "Waffles",
            "Woof",
            "Zen",
            "Tammy",
            "Tommy",
            "Zephyr",
            "Shea",
            "Hero",
            "Perry",
            "Dune",
            "Rascal",
            "Ripley",
            "Jonesy",
            "Pim"
        };
        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }
        private static Animal CreateRandomAnimal(int index)
        {
            Random gen = new Random();
            DateTime RandomBirthday()
            {
                DateTime start = new DateTime(2005, 1, 1);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(gen.Next(range));
            }
            DateTime birthday = RandomBirthday();
            
            Random acquireDate = new Random();
            DateTime RandomAcquirement(DateTime birthday)
            {
                DateTime start = birthday;
                int range = (DateTime.Today - start).Days;
                return start.AddDays(acquireDate.Next(range));
            }
            
            Random rand = new Random();
            return new Animal
            {
                Name = _names[index],
                Sex = rand.Next(0, 2) == 0 ? false : true,
                DateOfBirth = birthday,
                AcquirementDate = RandomAcquirement(birthday),
                AnimalTypeId = rand.Next(1, _animaltypes.Count()+1)  //randomly pick a number between 1 and number of AnimalTypes
            };
        }
    }
}
