using Microsoft.EntityFrameworkCore;
using ZooManagement.Models.Database;
using System;

namespace ZooManagement
{
    public class ZooManagementDbContext : DbContext
    {
        public ZooManagementDbContext(DbContextOptions<ZooManagementDbContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                    Id = 1,
                    Name = "Tammy",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2020/11/11"),
                    AcquirementDate = DateTime.Parse("2021/02/02"),
                    Class = "Mammal",
                    Family = "Canidae",
                    Genus = "Canis",
                    Species = "C. lupus",
                    Alias = "Wolf"
                },
                new Animal 
                {
                    Id = 2,
                    Name = "MiMi",
                    Sex = true,
                    DateOfBirth = DateTime.Parse("2018-03-30"),
                    AcquirementDate = DateTime.Parse("2021-01-01"),
                    Class = "Amphibian",
                    Family = "Dendrobatidae",
                    Genus = "Dendrobates",
                    Species = "D. tinctorius",
                    Alias = "Blue Poison Dart Frog"
                },
                new Animal
                {
                    Id = 3,
                    Name = "Pete",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2018-03-29"),
                    AcquirementDate = DateTime.Parse("2021-01-01"),
                    Class = "Amphibian",
                    Family = "Dendrobatidae",
                    Genus = "Dendrobates",
                    Species = "D. tinctorius",
                    Alias = "Blue Poison Dart Frog"
                },
                new Animal 
                {            
                    Id = 4,
                    Name = "Kiki",
                    Sex = true,
                    DateOfBirth = DateTime.Parse("2001-03-05"),
                    AcquirementDate = DateTime.Parse("2001-03-05"),
                    Class = "Bird",
                    Family = "Psittacidae",
                    Genus = "Psittacus",
                    Species = "P. erithacus",
                    Alias = "African grey parrot"
                },
                new Animal
                {            
                    Id = 5,        
                    Name = "Boris",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("1981-02-15"),
                    AcquirementDate = DateTime.Parse("1987-08-04"),
                    Class = "Bird",
                    Family = "Cacatuidae",
                    Genus = "Cacatua",
                    Species = "C. alba",
                    Alias = "Umbrella cockatoo"
                },
                new Animal
                {
                    Id = 6,
                    Name = "Nemo",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2020-12-01"),
                    AcquirementDate = DateTime.Parse("2021-01-31"),
                    Class = "Fish",
                    Family = "Pomacentridae",
                    Genus = "Amphiprion",
                    Species = "Amphiprion ocellaris",
                    Alias = "Clownfish"
                },
                new Animal
                {
                    Id = 7,
                    Name = "Dory",
                    Sex = true,
                    DateOfBirth = DateTime.Parse("2005-06-04"),
                    AcquirementDate = DateTime.Parse("2007-08-09"),
                    Class = "Fish",
                    Family = "Acanthuridae",
                    Genus = "Paracanthurus",
                    Species = "P. hepatus",
                    Alias = "Blue tang"
                },
                new Animal
                {
                    Id = 8,
                    Name = "Marlin",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2015-07-05"),
                    AcquirementDate = DateTime.Parse("2021-01-31"),
                    Class = "Fish",
                    Family = "Pomacentridae",
                    Genus = "Amphiprion",
                    Species = "Amphiprion ocellaris",
                    Alias = "Clownfish"
                },
                new Animal
                {
                    Id = 9,
                    Name = "Mooney",
                    Sex = true,
                    DateOfBirth = DateTime.Parse("2020-12-29"),
                    AcquirementDate = DateTime.Parse("2021-01-31"),
                    Class = "Invertebrate",
                    Family = "Ulmaridae",
                    Genus = "Aurelia",
                    Species = "A. aurita",
                    Alias = "Moon Jellyfish"
                },
                new Animal
                {
                    Id = 10,
                    Name = "Timmy",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2013-07-22"),
                    AcquirementDate = DateTime.Parse("2015-12-25"),
                    Class = "Mammal",
                    Family = "Canidae",
                    Genus = "Canis",
                    Species = "C. lupus",
                    Alias = "Wolf"
                },
                new Animal
                {
                    Id = 11,
                    Name = "Tommy",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2008-08-08"),
                    AcquirementDate = DateTime.Parse("2021-02-22"),
                    Class = "Mammal",
                    Family = "Caviidae",
                    Genus = "Hydrochoerus",
                    Species = "H. hydrochaeris",
                    Alias = "Capybara"
                },
                new Animal   
                {
                    Id = 12,
                    Name = "Billy",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2010-07-07"),
                    AcquirementDate = DateTime.Parse("2021-01-01"),
                    Class = "Mammal",
                    Family = "Ursidae",
                    Genus = "Ailuropoda",
                    Species = "A. melanoleuca",
                    Alias = "Panda"
                },
                new Animal
                {
                    Id = 13,
                    Name = "Ziggy",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2015-07-07"),
                    AcquirementDate = DateTime.Parse("2017-05-03"),
                    Class = "Reptile",
                    Family = "Eublepharidae",
                    Genus = "Eublepharis",
                    Species = "E. macularius",
                    Alias = "Leopard gecko"
                }
            );
        }
    }
}