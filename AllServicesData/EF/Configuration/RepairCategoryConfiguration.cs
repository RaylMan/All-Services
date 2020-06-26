using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    class RepairCategoryConfiguration : IEntityTypeConfiguration<RepairCategory>
    {
        public void Configure(EntityTypeBuilder<RepairCategory> builder)
        {
            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(e => e.ServiceTypeId)
                   .HasColumnName("Service_Type_Id")
                   .IsRequired();
            builder.Property(e => e.Description);

            builder.HasOne(d => d.ServiceType)
                   .WithMany(p => p.RepairCategories)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_RepairCategories_ServiceType");

        }
    }
}
