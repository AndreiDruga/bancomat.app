using bancomat.app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bancomat.app.Data.Repository.AccountToRepo
{
    public interface IAccountToRepository
    {
        public AccountTo GetByUserEmail(string userEmail);
        public void CreateAccountTo(AccountTo accountTo);
        public void UpdateUserAccountTo(AccountTo accountTo);
    }
}
