namespace ghabzinow.Services.IServices
{
    public interface ITransactionService
    {
        Task<bool> WithDrawalByInquiry(int userId, double amount);

    }
}
