using ghabzinow.DAL;
using ghabzinow.Repositories;
using ghabzinow.Repositories.Repository;
using ghabzinow.Services;
using ghabzinow.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace ghabzinow.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextDB _context;
        public UnitOfWork(ContextDB context)
        {
            _context = context;
            UserRepository = new UserRepository(context);
            UtilityBillsService =new UtilityBillsService();
            LogInquirtyRepository = new LogInquirtyRepository(context);
            TransactionRepository = new TransactionRepository(context);


        }

        public IUserRepository UserRepository { get; }
        public ILogInquirtyRepository LogInquirtyRepository { get; }
        public IUtilityBillsService UtilityBillsService { get; }
        public ITransactionRepository TransactionRepository { get;  }
        public async Task<int> CompleteAsync()
        {
            try
            {
                var entities = from e in _context.ChangeTracker.Entries()
                               where e.State == EntityState.Added
                                     || e.State == EntityState.Modified
                               select e.Entity;
                foreach (var entity in entities)
                {
                    var validationContext = new ValidationContext(entity);
                    Validator.ValidateObject(entity, validationContext);
                }

                return await _context.SaveChangesAsync();
            }
            catch (ValidationException ex)
            {
                return -1;
            }
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }
    }
}
