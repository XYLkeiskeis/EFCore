using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConnect
{
    public class UserRole
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}
