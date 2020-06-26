using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    internal class CompanyImageConfiguration : IEntityTypeConfiguration<CompanyImage>
    {
        public void Configure(EntityTypeBuilder<CompanyImage> builder)
        {
            builder.Property(e => e.ImageId)
                   .HasColumnName("Image_Id")
                   .IsRequired();
            builder.Property(e => e.CompanyId)
                   .HasColumnName("Company_Id")
                   .IsRequired();
            builder.HasOne(d => d.Image)
                  .WithMany(d => d.CompanyImages)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_Image_CompanyImage");
            builder.HasOne(d => d.Company)
                   .WithMany(d => d.CompanyImages)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Company_CompanyImage");
        }
    }
}
