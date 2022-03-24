using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Experiment4.Models
{
    public class TZF
    {
        [Key]
        public int TZFId { get; set; }
        public string Name { get; set; }
        public string TZFPhone { get; set; }
        public string Address { get; set; }
        public Project Project { get; set; }
    }
}
