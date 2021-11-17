using bancomat.app.Models;

namespace bancomat.app.Data.Repository.BalanceActionRepo
{
    public class AuditItemsRepository : IAuditItemsRepository
    {
        private readonly ApplicationDbContext _context;

        public AuditItemsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InsertAuditItem(AuditItem balanceAction)
        {
            _context.Set<AuditItem>()
                    .Add(balanceAction);

            _context.SaveChanges();
        }
    }
}
