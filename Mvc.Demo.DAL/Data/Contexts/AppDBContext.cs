﻿using Microsoft.EntityFrameworkCore;
using Mvc.Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Demo.DAL.Data.Contexts
{
    internal class AppDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyMVC;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Department> Departments { get; set; }
    }
}
