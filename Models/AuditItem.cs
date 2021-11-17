using System.ComponentModel.DataAnnotations;

namespace bancomat.app.Models
{
    public class AuditItem
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public double InitAmount { get; set; }
        public double NewAmount { get; set; }
        public string Details { get; set; }
    }
}
