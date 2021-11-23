using System.Collections.Generic;
namespace bancomat.app.Models.Transfer
{
    public class AccountTo
    {
        public string UserId { get; set; }
        public virtual ICollection<UserBalance> UserBalances { get; set; }
        public double Amount { get; set; }
        public string Details { get; set; }
    }
}
