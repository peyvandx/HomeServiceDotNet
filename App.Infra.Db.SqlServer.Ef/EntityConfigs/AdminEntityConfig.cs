using App.Domain.Core.Admin.Entities;
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
    public class AdminEntityConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(a => a.Id)
                .IsRequired();
            builder
                .Property(a => a.FirstName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property (a => a.LastName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(a => a.ProfileImage)
                .HasMaxLength(4000);
            //builder
            //    .Property(a => a.Email)
            //    .HasMaxLength(100)
            //    .IsRequired();
            //builder
            //    .Property(a => a.Password)
            //    .HasMaxLength(100)
            //    .IsRequired();
            //builder
            //    .Property(a => a.ConfirmPassword)
            //    .HasMaxLength(100)
            //    .IsRequired();
            //builder
            //    .Property(a => a.PhoneNumber)
            //    .HasMaxLength(11)
            //    .IsRequired();
            builder
                .Property(a => a.SignUpDate);

            //builder
            //    .HasMany(a => a.Comments)
            //    .WithOne(c => c.Admin)
            //    .HasForeignKey(c => c.AdminId)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new List<Admin>
            {
                new Admin()
                {
                    Id = 1,
                    FirstName = "ادمین",
                    LastName = "ادمینیان پور",
                    ProfileImage = "/UserAssets/img/admin/1.jpg",
                    ApplicationUserId = 1
				}
            });
        }
    }
}
