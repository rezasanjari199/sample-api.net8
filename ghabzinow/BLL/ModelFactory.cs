using ghabzinow.DAL;
using ghabzinow.Repositories;
using ghabzinow.Repositories.Repository;
using ghabzinow.Services;
using ghabzinow.Services.IServices;
using ghabzinow.UoW;

namespace ghabzinow.BLL
{
    public class ModelFactory:IModelFactory
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModelFactory(IUnitOfWork unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
            TransactionService =new TransactionService(_unitOfWork);
            TokenService = new TokenService();
        }
        public ITransactionService TransactionService{ get; }
        public ITokenService TokenService { get; }
    }
}
