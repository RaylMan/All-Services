using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    class ServiceTypeConfiguration : IEntityTypeConfiguration<ServiceType>
    {
        public void Configure(EntityTypeBuilder<ServiceType> builder)
        {
            builder.Property(e => e.Name)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(e => e.Description);
        }
    }
}
