using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bancomat.app.Models;

namespace bancomat.app.Data.Repository.AccountToRepo
{
    public class AccountToRepository : IAccountToRepository
    {
        private readonly ApplicationDbContext _context;
        
        public AccountToRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateAccountTo(Account accountTo)
        {
            _context.Set<Account>().Add(accountTo);
            _context.SaveChanges();
        }

        
        public Account GetByUserEmail(string userEmail)
        {
            return _context.Set<Account>().Where(at => at.Email == userEmail).FirstOrDefault();
        }

        public void UpdateUserAccountTo(Account accountTo)
        {
            _context.Set<Account>().Update(accountTo);
            _context.SaveChanges();
        }
    }
}
