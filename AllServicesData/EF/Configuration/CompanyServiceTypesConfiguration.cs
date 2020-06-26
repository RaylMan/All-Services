using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.EF.Configuration
{
    public class CompanyServiceTypesConfiguration : IEntityTypeConfiguration<CompanyServiceTypes>
    {
        public void Configure(EntityTypeBuilder<CompanyServiceTypes> builder)
        {
            builder.Property(e => e.ServiceTypeId)
                   .HasColumnName("Service_Type_Id")
                   .IsRequired();
                   
            builder.Property(e => e.CompanyId)
                   .HasColumnName("Company_Id")
                   .IsRequired();

            builder.HasOne(d => d.Company)
                   .WithMany(p => p.CompanyServiceTypes)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyServiceTypes_Service_Type");
            builder.HasOne(d => d.ServiceType)
                   .WithMany(p => p.CompanyServiceTypes)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyServiceTypes_User");
        }
    }
}
