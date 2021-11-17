using bancomat.app.Models;
using System.Linq;

namespace bancomat.app.Data.Repository.BalanceRepo
{
    public class BalanceRepository : IBalanceRepository
    {
        private readonly ApplicationDbContext _context;

        public BalanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateUserBalance(UserBalance userBalance)
        {
            _context.Set<UserBalance>().Add(userBalance);
            _context.SaveChanges();
        }

        public UserBalance GetByUserId(string userId)
        {
            return _context.Set<UserBalance>().Where(ub => ub.UserId == userId).FirstOrDefault();
        }

        public void UpdateUserBalance(UserBalance userBalance)
        {
            _context.Set<UserBalance>().Update(userBalance);
            _context.SaveChanges();
        }
    }
}
