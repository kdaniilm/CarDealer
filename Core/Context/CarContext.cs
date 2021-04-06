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
        public DbSet<Car> Cars { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<ShowContacts> ShowContacts { get; set; }
        public DbSet<UserCarBuff> UserCarBuffs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
