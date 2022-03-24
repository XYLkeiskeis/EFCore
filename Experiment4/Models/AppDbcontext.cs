using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment4.Models
{
    public class AppDbcontext:DbContext
    {
        public DbSet<CYCompany> CYCompany { get; set; }
        public DbSet<CYManagement> CYManagement { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<FhCompany> FhCompany { get; set; }
        public DbSet<FHManagement> FHManagement { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<TZF> TZF { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; DataBase = Experment4; User ID = sa; password = 123456");
        }
        
    }
}
