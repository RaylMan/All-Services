using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.EF.Configuration
{
    class CompanyManufacturerConfiguration : IEntityTypeConfiguration<CompanyManufacturer>
    {
        public void Configure(EntityTypeBuilder<CompanyManufacturer> builder)
        {
            builder.Property(e => e.ManufacturerId)
                   .HasColumnName("Manufacturer_Id")
                   .IsRequired();

            builder.Property(e => e.CompanyId)
                   .HasColumnName("Company_Id")
                   .IsRequired();

            builder.HasOne(d => d.Company)
                   .WithMany(p => p.CompanyManufacturers)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyManufacturers_Service_Type");
            builder.HasOne(d => d.Manufacturer)
                   .WithMany(p => p.CompanyManufacturers)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyManufacturers_Manufacturer");
        }
    }
}
