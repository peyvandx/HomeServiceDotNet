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
    public class ServiceRequestEntityConfig : IEntityTypeConfiguration<ServiceRequest>
    {
        public void Configure(EntityTypeBuilder<ServiceRequest> builder)
        {
            builder
                .HasKey(sr => sr.Id);
            builder
                .Property(sr => sr.Id)
                .IsRequired();
            builder
                .Property(sr => sr.CustomerDescription)
                .HasMaxLength(4000)
                .IsRequired();
            builder
                .Property(sr => sr.Status)
                .IsRequired();
            builder
                .Property(sr => sr.CreatedAt)
                .IsRequired();
            builder
                .Property(sr => sr.IsDeleted)
                .IsRequired();
            builder
                .Property(sr => sr.IsDone)
                .IsRequired();
            builder
                .Property(sr => sr.CustomerSuggestedPrice)
                .IsRequired();

            builder
                .HasOne(sr => sr.Service)
                .WithMany(s => s.ServiceRequests)
                .HasForeignKey(sr => sr.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(sr => sr.Proposals)
                .WithOne(p => p.ServiceRequest)
                .HasForeignKey(p => p.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(sr => sr.Comment)
                .WithOne(c => c.ServiceRequest)
                .HasForeignKey<Comment>(c => c.ServiceRequestId);
        }
    }
}
