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

        public void CreateAccountTo(AccountTo accountTo)
        {
            _context.Set<AccountTo>().Add(accountTo);
            _context.SaveChanges();
        }

        
        public AccountTo GetByUserEmail(string userEmail)
        {
            return _context.Set<AccountTo>().Where(at => at.Email == userEmail).FirstOrDefault();
        }

        public void UpdateUserAccountTo(AccountTo accountTo)
        {
            _context.Set<AccountTo>().Update(accountTo);
            _context.SaveChanges();
        }
    }
}
