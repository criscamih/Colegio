using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace wevap.Models.QueryModels
{
    [NotMapped]
    public class SubjectLevel
    {
        [Display(Name ="Curso")]
        public string Stage { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        public int Credits { get; set; }
    }
}