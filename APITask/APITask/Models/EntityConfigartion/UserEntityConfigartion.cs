using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace APITask.Models.EntityConfigartion
{
    public class UserEntityConfigartion : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.User_Id);
            builder.Property(x => x.User_Id).UseIdentityColumn();
            builder.HasIndex(x => x.Nationlity_Id).IsUnique();
            builder.Property(x => x.Nationlity_Id).HasMaxLength(10);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.User_Name).IsUnique();
            builder.Property(x => x.PhotoProfileUrl).IsRequired(false);
            builder.Property(x => x.Number_Phone).HasMaxLength(13);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsLoggedIn).HasDefaultValue(false);

        }
    }
}
