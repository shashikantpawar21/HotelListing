using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {            
        }

        DbSet<Country> Countries{get; set;}
        DbSet<Hotel> Hotels{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country{
                    Id = 1,
                    Name = "India",
                    ShortName = "IND"
                },  
                new Country{
                    Id = 2,
                    Name = "Russia",
                    ShortName = "RS"
                },
                new Country{
                    Id = 3,
                    Name = "America",
                    ShortName = "USA"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel{
                    Id= 1,
                    Name = "Taj",
                    Address = "Mumbai",
                    Rating =4.9,
                    CountryId =1
                },
                new Hotel{
                    Id= 2,
                    Name = "Russian Taj",
                    Address = "Belarus",
                    Rating =3.4,
                    CountryId =2
                },
                new Hotel{
                    Id= 3,
                    Name = "Star US",
                    Address = "Mexico",
                    Rating =4.0,
                    CountryId =3
                }
            );
        }
    }
}