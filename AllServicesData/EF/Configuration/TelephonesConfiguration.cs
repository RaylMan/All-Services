using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    internal class TelephonesConfiguration : IEntityTypeConfiguration<Telephones>
    {
        public void Configure(EntityTypeBuilder<Telephones> builder)
        {
            builder.Property(e => e.Telephone)
                   .IsRequired()
                   .HasMaxLength(30);
            builder.Property(e => e.CompanyId)
                   .HasColumnName("Company_Id")
                   .IsRequired()
                   .HasMaxLength(30);
            builder.HasOne(e => e.Company)
                   .WithMany(e => e.Telephones)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Telephones_Company");
        }
    }
}
