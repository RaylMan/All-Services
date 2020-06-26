using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.Property(e => e.Model)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(e => e.EquipmentTypeId)
                   .HasColumnName("EquipmentType_Id")
                   .IsRequired();
            builder.Property(e => e.ManufacturerId)
                   .HasColumnName("Manufacturer_Id")
                   .IsRequired();

            builder.HasOne(d => d.EquipmentType)
                   .WithMany(p => p.Equipments)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Equipments_EquipmentTypes");
            builder.HasOne(d => d.Manufacturer)
                   .WithMany(p => p.Equipments)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Equipments_Manufacturers");
        }
    }
}
