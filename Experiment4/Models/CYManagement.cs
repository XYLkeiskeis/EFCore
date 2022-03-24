using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Experiment4.Models
{
    public class CYManagement
    {
       
        public int CYId { get; set; }
        public string Phone { get; set; }
        [Key]
        public Guid CYNumber { get; set; }


        [ForeignKey("CYId")]
        public CYCompany CYCompany { get; set; }
        [ForeignKey("Phone")]
        public Employee Employee { get; set; }
    }
}
