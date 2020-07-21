using AllServicesData.EF.Configuration;
using AllServicesData.EF.Configuration.AddData;
using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;

namespace AllServicesData.EF
{
    public class AllServicesContext : DbContext
    {
        public AllServicesContext()
        {
        }
        public AllServicesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Access> Access { get; set; }
        public DbSet<Telephones> Telephones { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public DbSet<CompanyServiceType> CompanyServiceType { get; set; }
        public DbSet<CompanyManufacturer> CompanyManufacturers { get; set; }
        public DbSet<CompanyImage> CompanyImages { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<RepairCategory> RepairCategories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var connectionString = @"Server=DESKTOP-D6JRGFG\SQLEXPRESS;Database=AllServices;Trusted_Connection=True;";
                var connectionString = @"Server=ANDREY\SQLEXPRESS;Database=AllServices;Trusted_Connection=True;"; // User Id=service;password=password2020;Trusted_Connection=False;MultipleActiveResultSets=true;";
                optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccessConfiguration());
            modelBuilder.ApplyConfiguration(new TelephonesConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfigaration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyAddressConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyImageConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RepairCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyServiceTypesConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyManufacturerConfiguration());

            new DefaultData(modelBuilder);
            new TestData(modelBuilder);
        }
    }
}
