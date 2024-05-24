using App.Domain.Core.Customer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Ef.EntityConfigs
{
    public class AddressEntityConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(a => a.Id)
                .IsRequired();
            builder
                .Property(a => a.Street)
                .HasMaxLength(100);
            builder
                .Property(a => a.PostalCode)
                .HasMaxLength(20);
            builder
                .Property(a => a.CreatedAt)
                .IsRequired();
            builder
                .Property(a => a.IsDeleted);

            builder
                .HasOne(a => a.City)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
