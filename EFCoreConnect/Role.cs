using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConnect
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public User User { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
