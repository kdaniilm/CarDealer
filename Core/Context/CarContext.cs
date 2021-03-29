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
            builder.Entity<BoostType>().HasData(
                new BoostType[]
                {
                    new BoostType { Id = 1, Type = "N/A"},
                    new BoostType { Id = 2, Type = "Supercharger" },
                    new BoostType { Id = 3, Type = "Single Turbo" },
                    new BoostType { Id = 4, Type = "Twin turbo" },
                    new BoostType { Id = 5, Type = "Bi turbo" }
                });

            builder.Entity<PetrolType>().HasData(
                new PetrolType[]
                {
                    new PetrolType{Id = 1, Type = "Petrol"},
                    new PetrolType{Id = 2, Type = "Gas/Petrol"},
                    new PetrolType{Id = 3, Type = "Gas"},
                    new PetrolType{Id = 4, Type = "Diesel"},
                    new PetrolType{Id = 5, Type = "Hibrid"},
                    new PetrolType{Id = 6, Type = "Electric"}
                });

            builder.Entity<CreateCountry>().HasData(
                new CreateCountry[]
                {
                    new CreateCountry{Id = 1, CountryName = "Germany"},
                    new CreateCountry{Id = 2, CountryName = "Japan"},
                    new CreateCountry{Id = 3, CountryName = "USA"},
                    new CreateCountry{Id = 4, CountryName = "England"}
                });
            builder.Entity<CarBrend>().HasData(
                new CarBrend[]
                {
                    new CarBrend{Id = 1, BrendName = "Audi", CreateCountryId = 1},
                    new CarBrend{Id = 2, BrendName = "Nissan", CreateCountryId = 2},
                    new CarBrend{Id = 3, BrendName = "Dodge", CreateCountryId = 3},
                    new CarBrend{Id = 4, BrendName = "Bentley", CreateCountryId = 4}
                });
            builder.Entity<CarModel>().HasData(
                new CarModel[]
                {
                    new CarModel{Id = 1, ModelName = "RS3", BrendId = 1},
                    new CarModel{Id = 2, ModelName = "GT-R", BrendId = 2},
                    new CarModel{Id = 3, ModelName = "Durando", BrendId = 3},
                    new CarModel{Id = 4, ModelName = "Flying Spur", BrendId = 4}
                });
            builder.Entity<ComfortConfiguration>().HasData(
                new ComfortConfiguration[]
                {
                    new ComfortConfiguration{Id = 1, ConfigName = "Conditioner"},
                    new ComfortConfiguration{Id = 2, ConfigName = "Seats heating"},
                    new ComfortConfiguration{Id = 3, ConfigName = "Cruise control"}
                });
            builder.Entity<SaveConfiguration>().HasData(
               new SaveConfiguration[]
               {
                    new SaveConfiguration{Id = 1, ConfigName = "Air bags"},
                    new SaveConfiguration{Id = 2, ConfigName = "Sleeping check"}
               });
            builder.Entity<StateConfiguration>().HasData(
                new StateConfiguration[]
                {
                    new StateConfiguration{Id = 1, ConfigName = "Garage saving"},
                    new StateConfiguration{Id = 2, ConfigName = "Dont hit"},
                    new StateConfiguration{Id = 3, ConfigName = "First owner"}
                });
            builder.Entity<MultiMediaConfiguration>().HasData(
                new MultiMediaConfiguration[]
                {
                    new MultiMediaConfiguration{Id = 1, ConfigName = "MP3"},
                    new MultiMediaConfiguration{Id = 2, ConfigName = "Subbuffer"}
                });

            base.OnModelCreating(builder);
        }
    }
}
