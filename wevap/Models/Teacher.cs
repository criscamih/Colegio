using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wevap.Models
{
    public class Teacher
    {
        [Key]
        public string DNI { get; set; }
        [Required]
        [StringLength(50)]
        public string NameTeacher { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}