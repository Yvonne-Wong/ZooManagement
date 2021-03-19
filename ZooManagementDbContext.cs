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
        public DbSet<Enclosure> Enclosures { get; set; }
    }
}