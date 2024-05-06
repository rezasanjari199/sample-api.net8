using ghabzinow.Repositories.Repository;
using ghabzinow.Services.IServices;

namespace ghabzinow.UoW
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ILogInquirtyRepository LogInquirtyRepository { get; }
        ITransactionRepository TransactionRepository { get; }



        #region services
        IUtilityBillsService UtilityBillsService { get; }
        #endregion
        Task<int> CompleteAsync();
        void Dispose();
    }
}

