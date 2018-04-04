using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wevap.Models
{
    [Table("tblScores")]
    public class StudentSubject
    {
        [Key]
        public int Id_Score { get; set; }
        [Display(Name = "Nota I")]
        public string Score1 { get; set; }
        [Display(Name = "Nota II")]
        public string Score2 { get; set; }
        [Display(Name = "Nota III")]
        public string Score3 { get; set; }
        public virtual Subject Subjet { get; set; }
        public virtual Student Student { get; set; }
    }
}