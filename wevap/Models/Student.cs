using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace wevap.Models
{
    [Table("tblStudent")]
    public class Student
    {
        [Key]
        [Display(Name = "Código")]
        public string DNI { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Estudiante")]
        public string NameStudent { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Ingreso")]
        public DateTime DateInput { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Retiro")]
        public DateTime DateOutput { get; set; }
        public virtual ICollection<StudentSubject> Subjects { get; set; }
    }
}