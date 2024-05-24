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
                .HasMaxLength(20);
            builder
                .Property(p => p.IsDeleted);
            builder
                .Property(p => p.CreatedAt);


            builder.HasData(
               new Province { Id = 1, Name = "آذربایجان شرقی", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 2, Name = "آذربایجان غربی", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 3, Name = "اردبیل", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 4, Name = "اصفهان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 5, Name = "البرز", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 6, Name = "ایلام", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 7, Name = "بوشهر", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 8, Name = "تهران", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 9, Name = "چهارمحال و بختیاری", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 10, Name = "خراسان جنوبی", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 11, Name = "خراسان رضوی", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 12, Name = "خراسان شمالی", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 13, Name = "خوزستان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 14, Name = "زنجان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 15, Name = "سمنان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 16, Name = "سیستان و بلوچستان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 17, Name = "فارس", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 18, Name = "قزوین", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 19, Name = "قم", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 20, Name = "کردستان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 21, Name = "کرمان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 22, Name = "کرمانشاه", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 23, Name = "کهگیلویه و بویراحمد", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 24, Name = "گلستان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 25, Name = "گیلان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 26, Name = "لرستان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 27, Name = "مازندران", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 28, Name = "مرکزی", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 29, Name = "هرمزگان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 30, Name = "همدان", CreatedAt = DateTime.Now, IsDeleted = false },
               new Province { Id = 31, Name = "یزد", CreatedAt = DateTime.Now, IsDeleted = false }
               );
        }
    }
}
