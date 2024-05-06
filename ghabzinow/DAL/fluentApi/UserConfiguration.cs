using ghabzinow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ghabzinow.DAL.fluentApi
{
    public class UserConfiguration:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "Cor");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(128);
            builder.Property(x => x.Password).HasMaxLength(528);
            builder.Property(e => e.Phone)
            .IsRequired(); // اطمینان از اجباری بودن فیلد
        

        }
    }
}
