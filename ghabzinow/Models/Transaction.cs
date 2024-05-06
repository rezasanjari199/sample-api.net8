namespace ghabzinow.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public DateTime DateDone { get; set; } = new DateTime();
        public int UserId { get; set; }
        public User User { get; set; }
        public double Amount { get; set; }
    }
   public enum TypeTransaction
    {
        Withdrawal,
        deposit,
        
    }
}
