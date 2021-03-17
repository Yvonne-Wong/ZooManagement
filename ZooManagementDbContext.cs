using Microsoft.EntityFrameworkCore;
using ZooManagement.Models.Database;
using System;
using System.Collections.Generic;

namespace ZooManagement
{
    public class ZooManagementDbContext : DbContext
    {
        public ZooManagementDbContext(DbContextOptions<ZooManagementDbContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<AnimalType>().HasData(animals);

            modelBuilder.Entity<Animal>().OwnsOne(a => a.AnimalType).HasData(
                new Animal
                {
                    Id = 1,
                    Name = "Tammy",
                    Sex = false,
                    DateOfBirth = DateTime.Parse("2020/11/11"),
                    AcquirementDate = DateTime.Parse("2021/02/02"),
                    AnimalType = animals[0]
                }
                // ,
                // new Animal 
                // {
                //     Id = 2,
                //     Name = "MiMi",
                //     Sex = true,
                //     DateOfBirth = DateTime.Parse("2018-03-30"),
                //     AcquirementDate = DateTime.Parse("2021-01-01"),
                //     AnimalType = animals[1]
                   
                // },
                // new Animal
                // {
                //     Id = 3,
                //     Name = "Pete",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("2018-03-29"),
                //     AcquirementDate = DateTime.Parse("2021-01-01"),
                //     AnimalType = animals[1]
            
                // },
                // new Animal 
                // {            
                //     Id = 4,
                //     Name = "Kiki",
                //     Sex = true,
                //     DateOfBirth = DateTime.Parse("2001-03-05"),
                //     AcquirementDate = DateTime.Parse("2001-03-05"),
                //     AnimalType = animals[2]
                // },
                // new Animal
                // {            
                //     Id = 5,        
                //     Name = "Boris",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("1981-02-15"),
                //     AcquirementDate = DateTime.Parse("1987-08-04"),
                //     AnimalType = animals[3]
                // },
                // new Animal
                // {
                //     Id = 6,
                //     Name = "Nemo",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("2020-12-01"),
                //     AcquirementDate = DateTime.Parse("2021-01-31"),
                //     AnimalType = animals[4]
                // },
                // new Animal
                // {
                //     Id = 7,
                //     Name = "Dory",
                //     Sex = true,
                //     DateOfBirth = DateTime.Parse("2005-06-04"),
                //     AcquirementDate = DateTime.Parse("2007-08-09"),
                //     AnimalType = animals[5]
                // },
                // new Animal
                // {
                //     Id = 8,
                //     Name = "Marlin",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("2015-07-05"),
                //     AcquirementDate = DateTime.Parse("2021-01-31"),
                //     AnimalType = animals[4]
                // },
                // new Animal
                // {
                //     Id = 9,
                //     Name = "Mooney",
                //     Sex = true,
                //     DateOfBirth = DateTime.Parse("2020-12-29"),
                //     AcquirementDate = DateTime.Parse("2021-01-31"),
                //     AnimalType = animals[7]
                // },
                // new Animal
                // {
                //     Id = 10,
                //     Name = "Timmy",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("2013-07-22"),
                //     AcquirementDate = DateTime.Parse("2015-12-25"),
                //     AnimalType = animals[0]
                // },
                // new Animal
                // {
                //     Id = 11,
                //     Name = "Tommy",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("2008-08-08"),
                //     AcquirementDate = DateTime.Parse("2021-02-22"),
                //     AnimalType = animals[6]
                // },
                // new Animal   
                // {
                //     Id = 12,
                //     Name = "Billy",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("2010-07-07"),
                //     AcquirementDate = DateTime.Parse("2021-01-01"),
                //     AnimalType = animals[8]
                // },
                // new Animal
                // {
                //     Id = 13,
                //     Name = "Ziggy",
                //     Sex = false,
                //     DateOfBirth = DateTime.Parse("2015-07-07"),
                //     AcquirementDate = DateTime.Parse("2017-05-03"),
                //     AnimalType = animals[9]
                // }
            );
        }
    }
}