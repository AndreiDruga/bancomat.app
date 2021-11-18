using bancomat.app.Models;
using System.Linq;

namespace bancomat.app.Data.Repository.TransferToRepo
{
    public class AmountToRepository : IAmountToRepository
    {
        private readonly ApplicationDbContext _context;

        public AmountToRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public AmountTo GetByUserEmail(string Email)
        {
            return _context.Set<AmountTo>().Where(at => at.Email == Email).FirstOrDefault();
        }
    }
}
