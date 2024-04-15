using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class NotificationConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(n => n.NotificationId);
            builder.HasData(
                new Notification() { NotificationId = 1, UserId = 1, NotificationTitle = "Yeni Kampanya", NotificationDesc = "Tshirtlerde indirimden sizde yararlanın." }
                );
        }
    }
}
