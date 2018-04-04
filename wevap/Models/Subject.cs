using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wevap.Models
{
    public class Subject
    {
        [Key]
        public int Id_Subject { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Range(0,5)]
        public int Credits { get; set; }
        public virtual ICollection<StudentSubject> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual Level Level { get; set; }
    }
}