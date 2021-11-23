using System.ComponentModel.DataAnnotations;
namespace bancomat.app.Models
{
    public class UserBalance
    {
        [Key]
        public int Id { get; set; }
        public double Amount { get; set; }
        public string UserId { get; set; }
    }
}
