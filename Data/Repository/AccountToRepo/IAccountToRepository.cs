using bancomat.app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bancomat.app.Data.Repository.AccountToRepo
{
    public interface IAccountToRepository
    {
        public Account GetByUserEmail(string userEmail);
        public void CreateAccountTo(Account accountTo);
        public void UpdateUserAccountTo(Account accountTo);
    }
}
