using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.EF.Configuration
{
    public class CompanyServiceTypesConfiguration : IEntityTypeConfiguration<CompanyServiceType>
    {
        public void Configure(EntityTypeBuilder<CompanyServiceType> builder)
        {
            builder.Property(e => e.ServiceTypeId)
                   .HasColumnName("Service_Type_Id")
                   .IsRequired();
                   
            builder.Property(e => e.CompanyId)
                   .HasColumnName("Company_Id")
                   .IsRequired();

            builder.HasOne(d => d.Company)
                   .WithMany(p => p.CompanyServiceType)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyServiceType_Service_Type");
            builder.HasOne(d => d.ServiceType)
                   .WithMany(p => p.CompanyServiceType)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyServiceType_User");
        }
    }
}
