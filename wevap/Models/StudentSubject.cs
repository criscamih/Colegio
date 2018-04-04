using System.ComponentModel.DataAnnotations;

namespace wevap.Models
{
    public class StudentSubject
    {
        [Key]
        public int Id_Score { get; set; }
        public string Score1 { get; set; }
        public string Score2 { get; set; }
        public string Score3 { get; set; }
        public virtual Subject Subjet { get; set; }
        public virtual Student Student { get; set; }
    }
}