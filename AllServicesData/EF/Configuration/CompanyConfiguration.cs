using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(e => e.UserId)
                   .HasColumnName("User_Id")
                   .IsRequired();
            builder.Property(e => e.Email)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(e => e.LogoUrl);
            builder.Property(e => e.WebSiteUrl);
            builder.Property(e => e.Description)
                   .IsRequired();
            builder.Property(e => e.SmallDescription)
                   .IsRequired();
            builder.Property(e => e.Description)
                   .IsRequired()
                   .HasDefaultValue(0);
            builder.Property(e => e.Likes)
                   .IsRequired()
                   .HasDefaultValue(0);
            builder.Property(e => e.Dislikes)
                   .IsRequired()
                   .HasDefaultValue(0);
            builder.HasOne(d => d.User)
                   .WithMany(p => p.Companies)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Company_User");
        }
    }
}
