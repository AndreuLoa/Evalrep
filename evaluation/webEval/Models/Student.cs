using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webEval.Models
{
    public class Student
    {
        public enum sex
        {
            male,
            female
        }
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public sex gender { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}