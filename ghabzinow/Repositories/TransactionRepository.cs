using ghabzinow.DAL;
using ghabzinow.Models;
using ghabzinow.Repositories.Repository;
using System;

namespace ghabzinow.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        private readonly ContextDB _context;

        public TransactionRepository(ContextDB context) : base(context)
        {
            _context = context;
        }
    }
}
