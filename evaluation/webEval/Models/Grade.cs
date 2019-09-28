using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webEval.Models
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        [Required]
        [Range(0, 100)]
        public int score { get; set; }
        [Required]
        public string subject { get; set; }
        public Student Student { get; set; }
    }
}