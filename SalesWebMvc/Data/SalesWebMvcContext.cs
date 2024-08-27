using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }
        public DbSet<SalesWebMvc.Models.Department> Department { get; set; } = default!;
        public DbSet<SalesWebMvc.Models.SalesRecord> SalesRecord { get; set; }
        public DbSet<SalesWebMvc.Models.Seller> Seller { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Populando a tabela Departamento
            modelBuilder.Entity<Department>().HasData(new Department { Id = 4, Name = "Computers" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 5, Name = "Games" });

            //Populando a tabela de Vendedor
            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 1,
                Name = "Maria Betania",
                Email = "maria@gmail.com",
                BirthDate = new DateTime(1995, 10, 13),
                BaseSalary = 2500,
                DepartmentId = 1
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 2,
                Name = "Noah Taylor",
                Email = "angelafreeman@hotmail.com",
                BirthDate = new DateTime(1997, 02, 23),
                BaseSalary = 3509.52,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 3,
                Name = "Michelle Fischer",
                Email = "williamscarl@yahoo.com",
                BirthDate = new DateTime(1969, 06, 01),
                BaseSalary = 3468.94,
                DepartmentId = 4
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 4,
                Name = "Joseph Gallegos",
                Email = "maryhill@sims.com",
                BirthDate = new DateTime(1993, 10, 02),
                BaseSalary = 2286.02,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 5,
                Name = "Randall Chapman",
                Email = "qlara@costa.com",
                BirthDate = new DateTime(2003, 01, 21),
                BaseSalary = 3134.91,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 6,
                Name = "Jason Ortiz",
                Email = "juan97@yahoo.com",
                BirthDate = new DateTime(1995, 05, 20),
                BaseSalary = 2327.95,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 7,
                Name = "Carl Roberts",
                Email = "sampsondarin@adams-armstrong.net",
                BirthDate = new DateTime(1989, 01, 25),
                BaseSalary = 2142.67,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 8,
                Name = "Austin Smith",
                Email = "paulvaldez@maxwell.org",
                BirthDate = new DateTime(1973, 03, 16),
                BaseSalary = 2459.52,
                DepartmentId = 2
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 9,
                Name = "Thomas Rodriguez",
                Email = "melissa87@mooney.com",
                BirthDate = new DateTime(1979, 10, 07),
                BaseSalary = 4726.29,
                DepartmentId = 5
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 10,
                Name = "Kelly Salas",
                Email = "shawn91@weaver.com",
                BirthDate = new DateTime(1997, 08, 16),
                BaseSalary = 2367.17,
                DepartmentId = 4
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 11,
                Name = "James Garcia",
                Email = "osmith@scott-lucas.com",
                BirthDate = new DateTime(1983, 04, 13),
                BaseSalary = 3926.36,
                DepartmentId = 4
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 12,
                Name = "Sara Burke",
                Email = "kelseycastaneda@gmail.com",
                BirthDate = new DateTime(1993, 02, 14),
                BaseSalary = 2520.38,
                DepartmentId = 2
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 13,
                Name = "Carol Miller",
                Email = "brett72@blake.com",
                BirthDate = new DateTime(1961, 09, 11),
                BaseSalary = 2743.77,
                DepartmentId = 4
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 14,
                Name = "Michael Freeman",
                Email = "hfrank@perez-smith.com",
                BirthDate = new DateTime(1999, 11, 22),
                BaseSalary = 3184.5,
                DepartmentId = 2
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 15,
                Name = "Alicia Martinez",
                Email = "mitchell21@yahoo.com",
                BirthDate = new DateTime(1985, 07, 14),
                BaseSalary = 4813.74,
                DepartmentId = 1
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 16,
                Name = "Sandra Anderson",
                Email = "nicholasharmon@cruz-evans.biz",
                BirthDate = new DateTime(1984, 06, 19),
                BaseSalary = 3666.55,
                DepartmentId = 5
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 17,
                Name = "Brandon Young",
                Email = "lydia44@duncan-bush.info",
                BirthDate = new DateTime(1996, 07, 21),
                BaseSalary = 4064.55,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 18,
                Name = "Nicholas Reed",
                Email = "ianderson@hotmail.com",
                BirthDate = new DateTime(1994, 09, 09),
                BaseSalary = 2538.67,
                DepartmentId = 1
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 19,
                Name = "John Cook",
                Email = "robert49@yahoo.com",
                BirthDate = new DateTime(1998, 03, 29),
                BaseSalary = 2408.56,
                DepartmentId = 5
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 20,
                Name = "Amanda Bell",
                Email = "dhudson@hotmail.com",
                BirthDate = new DateTime(1984, 12, 20),
                BaseSalary = 3923.19,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 21,
                Name = "David Johnson",
                Email = "nmorris@gmail.com",
                BirthDate = new DateTime(1978, 06, 28),
                BaseSalary = 4293.63,
                DepartmentId = 2
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 22,
                Name = "Paul Evans",
                Email = "jacobpatrick@moses.com",
                BirthDate = new DateTime(1982, 05, 12),
                BaseSalary = 2558.67,
                DepartmentId = 5
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 23,
                Name = "Amanda Murphy",
                Email = "kenneth66@hotmail.com",
                BirthDate = new DateTime(1989, 06, 30),
                BaseSalary = 4185.0,
                DepartmentId = 3
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 24,
                Name = "Robyn Hobbs",
                Email = "kgriffin@hotmail.com",
                BirthDate = new DateTime(1979, 09, 28),
                BaseSalary = 2975.61,
                DepartmentId = 1
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 25,
                Name = "Ann Berry",
                Email = "kevinmcfarland@rice.org",
                BirthDate = new DateTime(1986, 04, 01),
                BaseSalary = 4133.33,
                DepartmentId = 4
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 26,
                Name = "Karen Clark",
                Email = "valerie71@johnston-mitchell.com",
                BirthDate = new DateTime(1996, 03, 17),
                BaseSalary = 3575.89,
                DepartmentId = 5
            });

            modelBuilder.Entity<Seller>().HasData(new Seller
            {
                Id = 27,
                Name = "Amber Gonzalez",
                Email = "rreed@carroll.com",
                BirthDate = new DateTime(1979, 12, 17),
                BaseSalary = 3662.07,
                DepartmentId = 2
            });

            //Populando a tabela Registro de Vendas
            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 1,
                Date = new DateTime(2023, 11, 17),
                Amount = 100.90,
                SellerId = 1,
                Status = Models.Enums.SaleStatus.billed,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 2,
                Date = new DateTime(2024, 02, 27),
                Amount = 947.62,
                SellerId = 3,
                Status = Models.Enums.SaleStatus.pending,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 3,
                Date = new DateTime(2024, 01, 31),
                Amount = 882.51,
                SellerId = 4,
                Status = Models.Enums.SaleStatus.canceled,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 4,
                Date = new DateTime(2024, 05, 28),
                Amount = 575.08,
                SellerId = 5,
                Status = Models.Enums.SaleStatus.billed,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 5,
                Date = new DateTime(2024, 03, 30),
                Amount = 486.29,
                SellerId = 8,
                Status = Models.Enums.SaleStatus.canceled,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 6,
                Date = new DateTime(2023, 11, 23),
                Amount = 412.94,
                SellerId = 6,
                Status = Models.Enums.SaleStatus.pending,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 7,
                Date = new DateTime(2024, 05, 08),
                Amount = 919.8,
                SellerId = 10,
                Status = Models.Enums.SaleStatus.pending,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 8,
                Date = new DateTime(2024, 03, 02),
                Amount = 852.85,
                SellerId = 9,
                Status = Models.Enums.SaleStatus.pending,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 9,
                Date = new DateTime(2024, 08, 13),
                Amount = 103.36,
                SellerId = 12,
                Status = Models.Enums.SaleStatus.pending,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 10,
                Date = new DateTime(2024, 03, 02),
                Amount = 536.45,
                SellerId = 13,
                Status = Models.Enums.SaleStatus.billed,
            });

            modelBuilder.Entity<SalesRecord>().HasData(new SalesRecord
            {
                Id = 11,
                Date = new DateTime(2024, 01, 02),
                Amount = 538.44,
                SellerId = 15,
                Status = Models.Enums.SaleStatus.billed,
            });
        }

    }
}
