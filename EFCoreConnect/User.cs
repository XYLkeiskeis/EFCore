using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConnect
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Employee Employee { get; set; }
        public List<Order> Orders { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
