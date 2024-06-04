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
    public class ProposalEntityConfig : IEntityTypeConfiguration<Proposal>
    {
        public void Configure(EntityTypeBuilder<Proposal> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .IsRequired();
            builder
                .Property(p => p.ExpertDescription)
                .HasMaxLength(4000)
                .IsRequired();
            builder
                .Property(p => p.CreatedAt)
                .IsRequired();
            builder
                .Property(p => p.IsDeleted)
                .IsRequired();
            builder
                .Property(p => p.IsAccepted);
            builder
                .Property(p => p.SuggestedPrice);
        }
    }
}
