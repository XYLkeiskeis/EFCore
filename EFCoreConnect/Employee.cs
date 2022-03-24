using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConnect
{
    public class Employee
    {
        public int UserId { get; set; }
        public int Name { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public int Address { get; set; }
        public int Email { get; set; }
        public int Section { get; set; }
        public DateTime CreateDateTime { get; set; }

        public User User { get; set; }
    }
}
