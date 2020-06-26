using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    internal class CompanyAddressConfiguration : IEntityTypeConfiguration<CompanyAddress>
    {
        public void Configure(EntityTypeBuilder<CompanyAddress> builder)
        {
            builder.Property(e => e.CompanyId)
                   .HasColumnName("Company_Id")
                   .IsRequired();
            builder.Property(e => e.Address)
                   .HasColumnName("Address")
                   .IsRequired();
            builder.HasOne(d => d.Company)
                   .WithMany(d => d.CompanyAddresses)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Company_CompanyAddress");
        }
    }
}
