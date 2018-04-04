using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace wevap.Models
{
    [Table("tblSubject")]
    public class Subject
    {
        [Key]
        public int Id_Subject { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Asignatura")]
        public string Description { get; set; }
        [Range(0,5)]
        [Display(Name = "Créditos")]
        public int Credits { get; set; }
        public virtual ICollection<StudentSubject> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual Level Level { get; set; }
    }
}