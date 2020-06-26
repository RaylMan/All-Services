using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllServicesData.EF.Configuration
{
    internal class UserConfigaration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            //builder.HasKey(u => new { u.Id, u.Telephone })
            //       .HasName("PK_Users");
            //builder.Property(e => e.Id)
            //       .ValueGeneratedOnAdd();
            builder.Property(e => e.AccessId)
                   .HasColumnName("Acceess_Id")
                   .IsRequired();
            builder.Property(e => e.Telephone)
                   .IsRequired()
                   .HasMaxLength(30);
            builder.Property(e => e.Email)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(e => e.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(e => e.FirstName)
                   .IsRequired()
                   .HasMaxLength(30);
            builder.Property(e => e.LastName)
                   .IsRequired()
                   .HasMaxLength(30);
            builder.Property(e => e.Adress)
                   .IsRequired();
            builder.Property(e => e.Token);
                 
            builder.HasOne(d => d.Access)
                   .WithMany(p => p.Users)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Users_Access");
        }
    }
}