using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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