using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Experiment4.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Phone { get; set; }
        public int CYId { get; set; }
        public int TZFId { get; set; }
        public string ProjectName { get; set; }


        [ForeignKey("Phone")]
        public Employee Employee { get; set; }

        [ForeignKey("CYId")]
        public CYCompany CyCompany { get; set; }

        [ForeignKey("TZFId")]
        public TZF TZF { get; set; }
    }
}
