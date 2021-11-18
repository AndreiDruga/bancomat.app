using bancomat.app.Models;



namespace bancomat.app.Data.Repository.TransferToRepo
{
   public interface IAmountToRepository
    {
        public AmountTo GetByUserEmail(string Email);

    }
}
