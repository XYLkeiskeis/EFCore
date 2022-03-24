using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Experiment4.Models
{
    public class FHManagement
    {
        public int HFId { get; set; }
        public string Phone { get; set; }
        [Key]
        public Guid FHNumber { get; set; }

        [ForeignKey("Phone")]
        public Employee Employee { get; set; }
        [ForeignKey("FhId")]
        public FhCompany FhCompany { get; set; }

    }
}
