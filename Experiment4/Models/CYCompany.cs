using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Experiment4.Models
{
    public class CYCompany
    {
        [Key]
        public int CYId { get; set; }
        public string Name { get; set; }
        public int CreditCode { get; set; }
        public string Address { get; set; }
        public string FirmPhone { get; set; }


        public Project Project { get; set; }
        public CYManagement CYManagement { get; set; }

    }
}
