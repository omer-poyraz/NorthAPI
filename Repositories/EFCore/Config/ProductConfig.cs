using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.HasData(
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Tshirt", ProductDesc = "Yeni sezon pamuk tshirt.", ProductStar = 4, Price = 250 },
                new Product { ProductId = 2, CategoryId = 2, ProductName = "Mavi Kazak", ProductDesc = "Soğuk geçirmez kalın kazak.", ProductStar = 5, Price = 530 }
            );
        }
    }
}
