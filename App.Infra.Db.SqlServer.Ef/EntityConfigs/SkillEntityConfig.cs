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
    public class SkillEntityConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
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
                .Property(s => s.SelfRate)
                .IsRequired();
            builder
                .Property(s => s.CreatedAt)
                .IsRequired();
            builder
                .Property(s => s.IsDeleted)
                .IsRequired();
        }
    }
}
