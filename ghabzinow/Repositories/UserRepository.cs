using ghabzinow.DAL;
using ghabzinow.Models;
using ghabzinow.Repositories.Repository;
using System;

namespace ghabzinow.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ContextDB _context;

        public UserRepository(ContextDB context) : base(context)
        {
            _context = context;
        }
    }
}
