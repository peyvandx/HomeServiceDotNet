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
    public class ProvinceEntityConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .IsRequired();
            builder
                .Property(p => p.Name)
                .HasMaxLength(20)
                .IsRequired();
            builder
                .Property(p => p.IsDeleted)
                .IsRequired();
            builder
                .Property(p => p.CreatedAt)
                .IsRequired();
        }
    }
}
