using System.ComponentModel.DataAnnotations;
namespace bancomat.app.Models
{
    public class AuditItem
    {
        [Key]
        public int Id { set; get; }
        public string UserId { set; get; }
        public double InitAmount { set; get; }
        public double NewAmount { set; get; }
        public string Details { get; set; }
    }
}
