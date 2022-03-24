using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConnect
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CreateUserId { get; set; }
        public int Name { get; set; }
        public int Detail { get; set; }
        public int CreateTime { get; set; }
        public int UpdateTime { get; set; }
        public User User { get; set; }
    }
}
