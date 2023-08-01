using Microsoft.EntityFrameworkCore;
using Web_API.Models;
using Web_API.Models.Dto;

namespace Web_API.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Villa> villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa() 
                { 
                    Id=1,
                    Name="Royal Home",
                    Occupancy=10,
                    Sqft=1200,
                    CreatedTime=DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Shree Home",
                    Occupancy = 10,
                    Sqft = 1200,
                    CreatedTime = DateTime.Now
                }
                , 
                new Villa()
                {
                    Id = 3,
                    Name = "Sprash Home",
                    Occupancy = 10,
                    Sqft = 1200,
                    CreatedTime = DateTime.Now
                }
                );
        }
    }
}
