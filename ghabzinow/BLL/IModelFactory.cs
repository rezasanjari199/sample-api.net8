using ghabzinow.Repositories.Repository;
using ghabzinow.Services;
using ghabzinow.Services.IServices;

namespace ghabzinow.BLL
{
    public interface IModelFactory
    {
        ITransactionService TransactionService{ get; }
        ITokenService TokenService { get; }
    }
}
