using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.EF.Configuration.AddData
{
    public class DefaultData
    {
        ModelBuilder _modelBuilder;
        /// <summary>
        /// Заполняет БД основной информацией
        /// </summary>
        /// <param name="modelBuilder"></param>
        public DefaultData(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
            Initialize();
        }
        private void Initialize()
        {
            AddDefaultAccesses();
            AddDefaultCompanyLogo();
            AddDefaultServiceTypes();
            AddDefaultManufacturers();
        }
        private void AddDefaultAccesses()
        {
            _modelBuilder.Entity<Access>().HasData(
                new Access[]
                {
                    new Access{ Id=1, AccessName = AccessesEnum.Admin.ToString()},
                    new Access{ Id=2, AccessName = AccessesEnum.User.ToString()},
                    new Access{ Id=3, AccessName = AccessesEnum.Company.ToString()}
                });
        }
        private void AddDefaultCompanyLogo()
        {
            _modelBuilder.Entity<Image>().HasData(
                new Image[]
                {
                    new Image { Id = 1, Name = "All-Service_default-image.jpg", Path = "/Images/All-Service_default-image.jpg"}
                });
        }
        private void AddDefaultServiceTypes()
        {
            _modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType[]
                {
                    new ServiceType {Id =1, Name = "Смартфоны и гаджеты"},
                    new ServiceType {Id =2, Name = "Техника для кухни"},
                    new ServiceType {Id =3, Name = "Техника для дома"},
                    new ServiceType {Id =4, Name = "Компьютеры и ноутбуки"},
                    new ServiceType {Id =5, Name = "Телевизоры, аудио, видео"},
                    new ServiceType {Id =6, Name = "Фото и видео"},
                    new ServiceType {Id =7, Name = "Велосипеды и самокаты"},
                    new ServiceType {Id =8, Name = "Автомобили и мотоциклы"},
                    new ServiceType {Id =9, Name = "Сантехника"},
                    new ServiceType {Id =10, Name = "Строительство"},
                    new ServiceType {Id =11, Name = "Бензо-электроинструмент"},
                    new ServiceType {Id =12, Name = "Игры и развлечения"}
                });
        }
        private void AddDefaultManufacturers()
        {
            _modelBuilder.Entity<Manufacturer>().HasData(
               new Manufacturer[]
               {
                    new Manufacturer { Id = 1, Name = "Apple" },
                    new Manufacturer { Id = 2, Name = "Samsung" },
                    new Manufacturer { Id = 3, Name = "Xiaomi" },
                    new Manufacturer { Id = 4, Name = "Huawei" },
                    new Manufacturer { Id = 5, Name = "Beko" },
                    new Manufacturer { Id = 6, Name = "Electrolux" },
                    new Manufacturer { Id = 7, Name = "Gorenje" },
                    new Manufacturer { Id = 8, Name = "Bosch" },
                    new Manufacturer { Id = 9, Name = "Simmens" },
                    new Manufacturer { Id = 10, Name = "Liebherr" },
                    new Manufacturer { Id = 11, Name = "Asus" },
                    new Manufacturer { Id = 12, Name = "HP" },
                    new Manufacturer { Id = 13, Name = "Lenovo" },
                    new Manufacturer { Id = 14, Name = "Acer" },
                    new Manufacturer { Id = 15, Name = "Intel" },
                    new Manufacturer { Id = 16, Name = "AMD" },
                    new Manufacturer { Id = 17, Name = "Nvidia" },
                    new Manufacturer { Id = 18, Name = "Candy" },
                    new Manufacturer { Id = 19, Name = "LG" },
                    new Manufacturer { Id = 20, Name = "Canon" },
                    new Manufacturer { Id = 21, Name = "Nikon" },
                    new Manufacturer { Id = 22, Name = "Sony" },
                    new Manufacturer { Id = 23, Name = "Indesit" },
                    new Manufacturer { Id = 24, Name = "HTC" },
                    new Manufacturer { Id = 25, Name = "Hansa" },
                    new Manufacturer { Id = 26, Name = "Braun" },
                    new Manufacturer { Id = 27, Name = "Redmond" },
                    new Manufacturer { Id = 28, Name = "Rondell" },
                    new Manufacturer { Id = 29, Name = "Tefal" },
                    new Manufacturer { Id = 30, Name = "Toshiba" },
                    new Manufacturer { Id = 31, Name = "Whirlpool" },
                    new Manufacturer { Id = 32, Name = "ZyXEL" },
                    new Manufacturer { Id = 33, Name = "D-Link" },
                    new Manufacturer { Id = 34, Name = "ZTE" },
                    new Manufacturer { Id = 35, Name = "Eltex" },
                    new Manufacturer { Id = 36, Name = "BMW" },
                    new Manufacturer { Id = 37, Name = "Mersedes" },
                    new Manufacturer { Id = 38, Name = "Nissan" },
                    new Manufacturer { Id = 39, Name = "Audi" },
                    new Manufacturer { Id = 40, Name = "Lada" },
                    new Manufacturer { Id = 41, Name = "Toyota" },
                    new Manufacturer { Id = 42, Name = "Hyundai" },
                    new Manufacturer { Id = 43, Name = "Kia" },
                    new Manufacturer { Id = 44, Name = "Reno" },
                    new Manufacturer { Id = 45, Name = "Microsoft" },
                    new Manufacturer { Id = 46, Name = "Cannondale" },
                    new Manufacturer { Id = 47, Name = "Merida" },
                    new Manufacturer { Id = 48, Name = "Scott" },
                    new Manufacturer { Id = 49, Name = "GT" },
                    new Manufacturer { Id = 50, Name = "Giant" },
                    new Manufacturer { Id = 51, Name = "Honda" },
                    new Manufacturer { Id = 52, Name = "KAWASAKI" },
                    new Manufacturer { Id = 53, Name = "YAMAHA" },
               });
        }
    }
}
