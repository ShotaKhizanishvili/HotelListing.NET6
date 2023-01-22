using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Rooms Hotel Kazbegi",
                    Address = "Kazbegi",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel De France",
                    Address = "Nice",
                    CountryId = 2,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel Nuevo Madrid",
                    Address = "Madrid",
                    CountryId = 3,
                    Rating = 4.2
                }
            );
        }
    }
}
