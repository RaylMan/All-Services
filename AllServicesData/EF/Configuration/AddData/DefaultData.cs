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
                    new ServiceType {Id =2, Name = "Телевизоры, аудио, видео"},
                    new ServiceType {Id =3, Name = "Компьютеры и ноутбуки"},
                    new ServiceType {Id =4, Name = "Техника для офиса"},
                    new ServiceType {Id =5, Name = "Техника для дома"},
                    new ServiceType {Id =6, Name = "Техника для кухни"},
                    new ServiceType {Id =7, Name = "Красота и здоровье"},
                    new ServiceType {Id =8, Name = "Фото и видео"},
                    new ServiceType {Id =9, Name = "Игры и развлечения"},
                    new ServiceType {Id =10, Name = "Бензо-электроинструмент"},
                    new ServiceType {Id =11, Name = "Автомобили и мотоциклы"},
                    new ServiceType {Id =12, Name = "Велосипеды и самокаты"},
                    new ServiceType {Id =13, Name = "Строительство"},
                    new ServiceType {Id =14, Name = "Сантехника"}
                });
        }
    }
}
