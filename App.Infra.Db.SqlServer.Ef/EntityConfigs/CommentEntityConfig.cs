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
    public class CommentEntityConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasKey(c => c.Id);
            builder
                .Property(c => c.Id)
                .IsRequired();
            builder
                .Property(c => c.Description)
                .HasMaxLength(4000)
                .IsRequired();
            builder
                .Property(c => c.CreateDate)
                .IsRequired();
            builder
                .Property(c => c.IsDeleted)
                .IsRequired();
            builder
                .Property(c => c.IsConfirmed)
                .IsRequired();
            builder
                .Property(c => c.Rate)
                .IsRequired();

            //builder
            //    .HasOne(c => c.Customer)
            //    .WithMany(c => c.Comments)
            //    .HasForeignKey(c => c.Customer.Id)
            //    .OnDelete(DeleteBehavior.Restrict);
            //builder
            //    .HasOne(c => c.Expert)
            //    .WithMany(e => e.Comments)
            //    .HasForeignKey(c => c.ExpertId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
