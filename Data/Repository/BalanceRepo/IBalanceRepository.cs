using bancomat.app.Models;
namespace bancomat.app.Data.Repository.BalanceRepo
{
    public interface IBalanceRepository
    {
        public UserBalance GetByUserId(string userId);
        public void CreateUserBalance(UserBalance userBalance);
        public void UpdateUserBalance(UserBalance userBalance);
    }
}
