using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.AddressId);
            builder.HasData(
                new Address() { AddressId = 1, UserId = 1, AddressTitle = "Pursaklar", AddressText = "Ayyıldız mahallesi Mimar sinan sokak", AddressCity = "Ankara", AddressDistrict = "Pursaklar" },
                new Address() { AddressId = 2, UserId = 1, AddressTitle = "Yenimahalle", AddressText = "Fezvi Çakmak mahallesi Çınar sokak", AddressCity = "Ankara", AddressDistrict = "Yenimahalle" }
            );
        }
    }
}
