using ghabzinow.DAL.fluentApi;
using ghabzinow.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ghabzinow.DAL
{
    public class ContextDB:DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LogInquiry> logInquiries{ get; set; }
        public DbSet<Transaction> transactions { get; set; }
    }
}
