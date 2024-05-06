using ghabzinow.DAL;
using ghabzinow.Models;
using ghabzinow.Services.IServices;
using ghabzinow.UoW;


namespace ghabzinow.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TransactionService(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
            
        }

        public async Task<bool> WithDrawalByInquiry(int userId, double amount)
        {
            try
            {
                var user = _unitOfWork.UserRepository.Get(userId);
                if (user.Wallet < 5)
                {
                    return  false;
                }
                var transaction =new Transaction()
                {
                    UserId= userId,
                    Amount= amount,
                    TypeTransaction=TypeTransaction.Withdrawal
                        
                };
              await  _unitOfWork.TransactionRepository.AddAsync(transaction);
                var result=await _unitOfWork.CompleteAsync();
                if(result > -1)
                {
                    user.Wallet -= 5;
                    await _unitOfWork.CompleteAsync();

                }
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
