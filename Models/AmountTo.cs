using System.ComponentModel.DataAnnotations;

namespace bancomat.app.Models
{
    public class AmountTo
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public double Amount { get; set; }
    }
}
