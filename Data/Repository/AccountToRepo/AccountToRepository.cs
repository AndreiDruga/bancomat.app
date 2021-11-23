namespace bancomat.app.Data.Repository.AccountToRepo
{
    public class AccountToRepository : IAccountToRepository
    {
        private readonly ApplicationDbContext _context;
        
        public AccountToRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       

        //public void CreateAccountTo(Account accountTo)
        //{
            
        //    //_context.Set<Account>().Add(accountTo);
        //    _context.SaveChanges();
        //}

       
    }
}
