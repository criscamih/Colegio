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
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Deber de tipo 4.5")]
        [Range(0.00,5.00,ErrorMessage ="La nota va de 0-5")]
        public string Score1 { get; set; }
        [Display(Name = "Nota II")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Deber de tipo 4.5")]
        [Range(0.00, 5.00, ErrorMessage = "La nota va de 0-5")]
        public string Score2 { get; set; }
        [Display(Name = "Nota III")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Deber de tipo 4.5")]
        [Range(0.00, 5.00, ErrorMessage = "La nota va de 0-5")]
        public string Score3 { get; set; }
        public virtual Subject Subjet { get; set; }
        public virtual Student Student { get; set; }
    }
}