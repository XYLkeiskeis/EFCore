using Experiment4.Models;
using System;
using System.Linq;


namespace Experiment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var db = new AppDbcontext())
            {
                Employee employee = new Employee()
                {
                    Name = "张三",
                    IdCard = "123213213131",
                    Address = "重庆",
                    Sex = "男",
                    Phone = "12312313"

                };
                db.Add(employee);
                db.SaveChanges();
                            
                      
            }
        }
    }
}
