using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    class EquipmentTypeConfiguration : IEntityTypeConfiguration<EquipmentType>
    {
        public void Configure(EntityTypeBuilder<EquipmentType> builder)
        {
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(e => e.ServiceTypeId)
                   .HasColumnName("ServiceType_Id")
                   .IsRequired();
            builder.HasOne(d => d.ServiceType)
                   .WithMany(p => p.EquipmentTypes)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_ServiceType_EquipmentTypes");
        }
    }
}
