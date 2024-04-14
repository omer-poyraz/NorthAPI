using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Defacto", CategoryImg = "https://dfcdn.defacto.com.tr/AssetsV2/dist/img/de-facto-logo-light-v2.svg" },
                new Category { CategoryId = 2, CategoryName = "Mavi", CategoryImg = "https://upload.wikimedia.org/wikipedia/commons/2/28/Logo_of_Mavi.png" }
            );
        }
    }
}
