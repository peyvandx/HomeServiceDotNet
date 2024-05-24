using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.Entities;
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
                .HasMaxLength(50);
            builder
                .Property(c => c.LastName)
                .HasMaxLength(50);
            builder
                .Property(c => c.ProfileImage)
                .HasMaxLength(500);
            builder
                .Property(c => c.AboutMe)
                .HasMaxLength(4000);
            builder
                .Property(c => c.FacebookAddress)
                .HasMaxLength(50);
            builder
                .Property(c => c.TwitterAddress)
                .HasMaxLength(50);
            builder
                .Property(c => c.InstagramAddress)
                .HasMaxLength(50);
            builder
                .Property(c => c.LinkedinAddress)
                .HasMaxLength(50);
            builder
                .Property(c => c.SignUpDate);
            builder
                .Property(c => c.IsDeleted)
                .IsRequired();
            //builder
            //    .Property(c => c.IsConfirmed)
            //    .IsRequired();

            //builder
            //    .HasOne(c => c.Admin)
            //    .WithMany(a => a.Customers)
            //    .OnDelete(DeleteBehavior.Restrict);
            //builder
            //    .HasOne(c => c.Address)
            //    .WithOne(a => a.Customer)
            //    .HasForeignKey(a => a.CustomerId)
            //    .OnDelete(DeleteBehavior.Restrict);
			builder
				.HasOne(c => c.Address)
				.WithOne(a => a.Customer)
				.HasForeignKey<Customer>(c => c.AddressId)
				.OnDelete(DeleteBehavior.Restrict);
			builder
                .HasMany(c => c.Comments)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(c => c.ServiceRequests)
                .WithOne(sr => sr.Customer)
                .HasForeignKey(sr => sr.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new List<Customer>
            {
                new Customer ()
                {
                    Id = 1,
                    FirstName = "علی",
                    LastName = "محمدی",
                    ProfileImage = "/UserAssets/img/customer/1.jpg",
                    ApplicationUserId = 2
                },

				new Customer ()
				{
					Id = 2,
					FirstName = "سحر",
					LastName = "رمضانی",
					ProfileImage = "/UserAssets/img/customer/2.jpg",
                    ApplicationUserId = 3
				},

				new Customer ()
				{
					Id = 3,
					FirstName = "مریم",
					LastName = "اکبری",
					ProfileImage = "/UserAssets/img/customer/3.jpg",
                    ApplicationUserId = 4
				}
			});
        }
    }
}
