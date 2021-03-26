using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Context
{
    public class CarContext : IdentityDbContext<User,Role,Guid>
    {
        public CarContext(DbContextOptions<CarContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ImagePath> ImagePaths { get; set; }
        public DbSet<BaseConfiguration> BaseConfigurations { get; set; }
        public DbSet<BoostType> BoostTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrend> CarBrends { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<ComfortConfiguration> ComfortConfigurations { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CreateCountry> CreateCountries { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<EngineCharacteristics> EngineCharacteristics { get; set; }
        public DbSet<MultiMediaConfiguration> MultiMediaConfigurations { get; set; }
        public DbSet<PetrolType> PetrolTypes { get; set; }
        public DbSet<SaveConfiguration> SaveConfigurations { get; set; }
        public DbSet<ShowContacts> ShowContacts { get; set; }
        public DbSet<StateConfiguration> StateConfigurations { get; set; }
        public DbSet<UserCarBuff> userCarBuffs { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<BoostType>().HasData(
            //    new BoostType[]
            //    {
            //        new BoostType { Id = 1, Type = "N/A"},
            //        new BoostType { Id = 2, Type = "Supercharger" },
            //        new BoostType { Id = 3, Type = "Single Turbo" },
            //        new BoostType { Id = 4, Type = "Twin turbo" },
            //        new BoostType { Id = 5, Type = "Bi turbo" }
            //    });

            //builder.Entity<PetrolType>().HasData(
            //    new PetrolType[]
            //    {
            //        new PetrolType{Id = 1, Type = "Petrol"},
            //        new PetrolType{Id = 1, Type = "Gas/Petrol"},
            //        new PetrolType{Id = 1, Type = "Gas"},
            //        new PetrolType{Id = 1, Type = "Diesel"},
            //        new PetrolType{Id = 1, Type = "Hibrid"},
            //        new PetrolType{Id = 1, Type = "Electric"}
            //    });
            
            //builder.Entity<CreateCountry>().HasData(
            //    new CreateCountry[]
            //    {
            //        new CreateCountry{Id = 1, CountryName = "Germany"},
            //        new CreateCountry{Id = 1, CountryName = "Japan"},
            //        new CreateCountry{Id = 1, CountryName = "USA"},
            //        new CreateCountry{Id = 1, CountryName = "England"}
            //    });
            //builder.Entity<Car>().HasData(
            //    new Car { Id = 1, Owner = null }
            //    );
            //builder.Entity<User>().HasData(
            //    new User { UserCar = null, FavoriteCar = null, SawContacts = null }
            //    );
        }
    }
}
