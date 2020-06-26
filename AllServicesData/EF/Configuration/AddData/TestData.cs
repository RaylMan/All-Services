using AllServicesData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllServicesData.EF.Configuration.AddData
{
    public class TestData
    {
        ModelBuilder _modelBuilder;
        /// <summary>
        /// Заполняет БД тестовой информацией
        /// </summary>
        /// <param name="modelBuilder"></param>
        public TestData(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
            Initialize();
        }

        private void Initialize()
        {
            AddUsers();
        }
        private void AddUsers()
        {
            _modelBuilder.Entity<User>().HasData(
               new User[]
               {
                    new User{ Id=1, AccessId = 1, Adress = "admin", Email= "admin", LastName= "admin", FirstName= "admin", PasswordHash= "admin", Telephone = "admin" },
                    new User{ Id=2, AccessId = 2, Adress = "user", Email= "user", LastName= "user", FirstName= "user", PasswordHash= "user", Telephone = "user" },
                    new User{ Id=3, AccessId = 3, Adress = "company", Email= "company", LastName= "company", FirstName= "company", PasswordHash= "company", Telephone = "company" },
               });
        }
    }
}
