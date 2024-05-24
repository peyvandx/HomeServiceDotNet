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
    public class ExpertEntityConfig : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder
                .HasKey(e => e.Id);
            builder
                .Property(e => e.Id)
                .IsRequired();
            builder
                .Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(e => e.LastName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(e => e.Age);
            builder
                .Property(e => e.ProfileImage)
                .HasMaxLength(500);
            builder
                .Property(e => e.AboutMe)
                .HasMaxLength(4000);
            builder
                .Property(e => e.FacebookAddress)
                .HasMaxLength(50);
            builder
                .Property(e => e.TwitterAddress)
                .HasMaxLength(50);
            builder
                .Property(e => e.InstagramAddress)
                .HasMaxLength(50);
            builder
                .Property(e => e.LinkedinAddress)
                .HasMaxLength(50);
            builder
                .Property(e => e.SignUpDate)
                .IsRequired();
            builder
                .Property(e => e.IsDeleted)
                .IsRequired();
            //builder
            //    .Property(e => e.IsConfirmed)
            //    .IsRequired();

            //builder
            //    .HasOne(e => e.Admin)
            //    .WithMany(a => a.Experts)
            //    .HasForeignKey(e => e.AdminId)
            //    .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(e => e.Address)
                .WithOne(a => a.Expert)
                .HasForeignKey<Expert>(e => e.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(e => e.Proposals)
                .WithOne(p => p.Expert)
                .HasForeignKey(p => p.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(e => e.Comments)
                .WithOne(c => c.Expert)
                .HasForeignKey(c => c.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(e => e.Skills)
                .WithOne(s => s.Expert)
                .HasForeignKey(s => s.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(e => e.DonedServiceRequests)
                .WithOne(sr => sr.Expert)
                .HasForeignKey(sr => sr.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(e => e.Services)
                .WithMany(s => s.Experts);

            builder.HasData(new List<Expert>
            {
                new Expert()
                {
                    Id = 1,
					FirstName = "افشین",
					LastName = "احمدیان‌پور",
					ProfileImage = "/UserAssets/img/expert/1.jpg",
                    ApplicationUserId = 5
				},
                new Expert()
                {
                    Id = 2,
                    FirstName = "فاران",
                    LastName = "علی‌زاده",
                    ProfileImage = "/UserAssets/img/expert/1.jpg",
                    ApplicationUserId = 6
                },
                new Expert()
                {
                    Id = 3,
                    FirstName = "آیدا",
                    LastName = "بهرامی",
                    ProfileImage = "/UserAssets/img/expert/2.jpg",
                    ApplicationUserId = 7
                }
            });
        }
    }
}
