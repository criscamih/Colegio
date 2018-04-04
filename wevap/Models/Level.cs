using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace wevap.Models
{
    [Table("tblLevel")]
    public class Level
    {
        [Key]
        public int Id_Level { get; set; }
        [Display(Name = "Curso")]
        public string Stage { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}