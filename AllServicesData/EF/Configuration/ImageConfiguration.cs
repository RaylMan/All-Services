using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    internal class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(e => e.Name)
                   .IsRequired();
            builder.Property(e => e.Path)
                   .IsRequired();
        }
    }
}
