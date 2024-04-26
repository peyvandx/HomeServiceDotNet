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
    public class CustomerEntityConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(c => c.Id);
            builder
                .Property(c => c.Id)
                .IsRequired();
            builder
                .Property(c => c.FirstName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(c => c.LastName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(c => c.Password)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(c => c.ConfirmPassword)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(c => c.PhoneNumber)
                .HasMaxLength(11)
                .IsRequired();
            builder
                .Property(c => c.ProfileImage)
                .HasMaxLength(4000);

            builder
                .HasOne(c => c.Admin)
                .WithMany(a => a.Customers);
            builder
                .HasMany(c => c.SubmittedComments)
                .WithOne(sc => sc.Customer);
            builder
                .HasMany(c => c.ReceivedComments)
                .WithOne(rc => rc.Customer);
            builder
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Customer);
            builder
                .HasMany(c => c.ServiceRequests)
                .WithOne(sr => sr.Customer);
        }
    }
}
