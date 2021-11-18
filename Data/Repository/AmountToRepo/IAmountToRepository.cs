using bancomat.app.Models;



namespace bancomat.app.Data.Repository.TransferToRepo
{
    interface IAmountToRepository
    {
     
        public AmountTo GetByUserEmail(string Email);

    }
}
