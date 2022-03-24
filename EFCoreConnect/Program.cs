using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Newtonsoft.Json;

namespace EFCoreConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectString = "Data Source =.; DataBase = CodeFirstAutoCreate; User ID = sa; password = 123456";
            //using (var db = new TestCodeFirstContext(connectString))
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();
            //    Console.WriteLine("实体映射成功");

            //}


            using (var db = new TestCodeFirstContext(connectString))
            {
                var user = db.Users.FirstOrDefault();
                var transferQuery = new User()
                {
                    Id = 1,
                    Name = "xyl",
                    Password = "123456",
                    Sex = "male"
                };
                
                

                var serializeQuery = JsonConvert.SerializeObject(transferQuery);


                //var query2 = (from user in db.Set<User>()
                //              select user.Name, user.Password);

                //var query4 = (from user in db.Set<User>()
                //              where user.Id == 2
                //              select user).FirstOrDefault();
                //var xx = db.Users.Select(u => u.Id);
                Console.WriteLine();


            //var users = context.Users.GroupBy(d => d.Id)
            //    .Select(g => new
            //    {
            //        id = g,
            //        count = g.Count()
            //    }).ToList();

            //var query1 = context.Users.Include(u => u.Id)
            //            .Select(u => new
            //            {
            //                Id = u.Id,
            //                Sex=u.Sex,
            //                Name = u.Name,
            //                Password = u.Password
            //            }).ToList();
            }
        }
    }
}
