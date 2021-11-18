namespace bancomat.app.Models.Transfer
{
    public class ChangeBalanceModel
    {
        public int Amount { get; set; }
        public bool ToIncrement { get; set; }
    }
}
