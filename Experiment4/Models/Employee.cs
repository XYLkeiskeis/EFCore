using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Experiment4.Models
{
    public class Employee
    {
        [Key]
        public string Phone { get; set; }
        public string IdCard { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }

        
        public List<FHManagement> FHManagement { get; set; }
        public Project Project { get; set; }
        public List<CYManagement> CYManagement { get; set; }
    }
}
