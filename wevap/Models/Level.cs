using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wevap.Models
{
    public class Level
    {
        [Key]
        public int Id_Level { get; set; }
        public string Stage { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}