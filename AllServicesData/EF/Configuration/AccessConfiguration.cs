using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    internal class AccessConfiguration : IEntityTypeConfiguration<Access>
    {
        public void Configure(EntityTypeBuilder<Access> builder)
        {
            //builder.Property(e => e.Id)
            //       .ValueGeneratedOnAdd();
            builder.Property(e => e.AccessName)
                   .HasColumnName("Access_Name")
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
