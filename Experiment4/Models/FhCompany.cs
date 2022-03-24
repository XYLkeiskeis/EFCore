using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Experiment4.Models
{
    public class FhCompany
    {
        [Key]
        public int FhId { get; set; }
        public string Name { get; set; }
        public string FirmPhone { get; set; }
        public string CreditCode { get; set; }
        public string Address { get; set; }

    }
}
