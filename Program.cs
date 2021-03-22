using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using ZooManagement.Data;
using System.Data.Entity.Migrations;

namespace ZooManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);
            
            host.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<ZooManagementDbContext>();
            context.Database.EnsureCreated();

            if (!context.Animals.Any())
            {
                var enclosures = SampleEnclosures.GetEnclosures();
                context.Enclosures.AddRange(enclosures);
                context.SaveChanges();

                var animaltypes = SampleAnimalTypes.GetAnimalTypes(context);
                context.AnimalTypes.AddRange(animaltypes);
                context.SaveChanges();

                var animals = SampleAnimals.GetAnimals();
                context.Animals.AddRange(animals);
                context.SaveChanges();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


