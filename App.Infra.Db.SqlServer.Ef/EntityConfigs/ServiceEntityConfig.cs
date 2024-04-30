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
    public class ServiceEntityConfig : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                .HasKey(s => s.Id);
            builder
                .Property(s => s.Id)
                .IsRequired();
            builder
                .Property(s => s.Title)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(s => s.Description)
                .HasMaxLength(4000)
                .IsRequired();
            builder
                .Property(s => s.Image)
                .HasMaxLength(4000)
                .IsRequired();
            builder
                .Property(s => s.WorkExperience)
                .IsRequired();
            builder
                .Property(s => s.CreatedAt)
                .IsRequired();
            builder
                .Property(s => s.IsDeleted)
                .IsRequired();

            builder
                .HasOne(s => s.Category)
                .WithMany(c => c.Services)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new Service { Id = 1, Title = "کاشی و سرامیک", CategoryId = 1, Image = "", Description = "", CreatedAt = DateTime.Now, IsDeleted = false }
                );
        }
    }
}
