using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace HotelListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                Id = 1,
                    Name = "Georgia",
                    ShortName = "GE"
                },
                new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "FR"
                },
                new Country
                {
                    Id = 3,
                    Name = "Spain",
                    ShortName = "ES"
                }
            );
        }
    }
}
