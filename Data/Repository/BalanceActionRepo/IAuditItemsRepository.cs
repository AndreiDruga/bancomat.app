using bancomat.app.Models;
namespace bancomat.app.Data.Repository.BalanceActionRepo
{
    public interface IAuditItemsRepository
    {
        public void InsertAuditItem(AuditItem balanceAction);
    }
}
