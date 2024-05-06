using ghabzinow.DAL;
using ghabzinow.Models;
using ghabzinow.Repositories.Repository;

namespace ghabzinow.Repositories
{
    public class LogInquirtyRepository:Repository<LogInquiry>,ILogInquirtyRepository
    {
        private readonly ContextDB _context;

        public LogInquirtyRepository(ContextDB context) : base(context)
        {
            _context = context;
        }
    }
}
