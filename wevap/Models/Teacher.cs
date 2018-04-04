using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wevap.Models
{
    [Table("tblTeacher")]
    public class Teacher
    {
        [Key]
        [Display(Name = "Código")]
        public string DNI { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Docente")]
        public string NameTeacher { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}