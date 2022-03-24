using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConnect
{
    public class TestCodeFirstContext : DbContext
    {
        private string connectString;
        public TestCodeFirstContext(string conn)
        {
            connectString = conn;

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("TB_User");
                entity.HasKey(c => c.Id);
                entity.HasIndex(c => c.Name);
                entity.Property(c => c.Name).IsRequired();
                entity.HasData(new User
                {
                    Id = 1,
                    Name="xyl",
                    Sex="male",
                    Password="123456"
                });
            });
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("TB_Role");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.RoleName).IsRequired();
            });
            //一对一
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("TB_Employee");
                entity.Property(c => c.Name).HasMaxLength(64).IsRequired();
                entity.HasKey(c => c.UserId);
                entity.HasOne(c => c.User).WithOne(c => c.Employee);

                //entity.HasKey(c => c.XXX);
                //entity.HasOne(c => c.User).WithOne(c => c.Employee).HasForeignKey<Employee>("XXX");
            });
            //一对多
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("TB_Order");
                entity.Property(c => c.Name).HasMaxLength(64).IsRequired();
                entity.HasKey(c => c.OrderId);
                entity.HasOne(c => c.User).WithMany(c => c.Orders).HasForeignKey(c => c.CreateUserId);
            });
            //多对多
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.HasOne(c => c.User).WithMany(c => c.UserRoles);
                entity.HasOne(c => c.Role).WithMany(c => c.UserRoles);
                
            });
            base.OnModelCreating(modelBuilder);


            //using (var db = new TestCodeFirstContext(connectString))
            //{
            //    var user = new User()
            //    {
            //        Id = 1,
            //        Name = "xyl",
            //        Password = "xyl123",
            //        Sex = "男"
            //    };
                
            //}




        }
    }
}
