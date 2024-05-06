using ghabzinow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ghabzinow.DAL.fluentApi
{
    public class TransactionConfiguration: IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions", "Cor");
            builder.HasKey(x => x.Id);
            builder.HasOne(s => s.User).WithMany().HasForeignKey(x => x.UserId);

        }
    }
}
