using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wevap.Models
{
    public class Student
    {
        [Key]
        public string DNI { get; set; }
        [Required]
        [StringLength(50)]
        public string NameStudent { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateInput { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOutput { get; set; }
        public virtual ICollection<StudentSubject> Subjects { get; set; }
    }
}