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
    public class CityEntityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasKey(c => c.Id);
            builder
                .Property(c => c.Id)
                .IsRequired();
            builder
                .Property(c => c.Name)
                .HasMaxLength(20)
                .IsRequired();
            builder
                .Property(c => c.CreatedAt)
                .IsRequired();
            builder
                .Property(c => c.IsDeleted)
                .IsRequired();

            //builder
            //    .HasOne(c => c.Province)
            //    .WithMany(p => p.Cities)
            //    .HasForeignKey(c => c.ProvinceId)
            //    .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
               new City { Id = 1, Name = "آذربایجان شرقی", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 2, Name = "آذربایجان غربی", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 3, Name = "اردبیل", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 4, Name = "اصفهان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 5, Name = "البرز", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 6, Name = "ایلام", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 7, Name = "بوشهر", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 8, Name = "تهران", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 9, Name = "چهارمحال و بختیاری", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 10, Name = "خراسان جنوبی", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 11, Name = "خراسان رضوی", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 12, Name = "خراسان شمالی", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 13, Name = "خوزستان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 14, Name = "زنجان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 15, Name = "سمنان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 16, Name = "سیستان و بلوچستان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 17, Name = "فارس", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 18, Name = "قزوین", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 19, Name = "قم", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 20, Name = "کردستان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 21, Name = "کرمان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 22, Name = "کرمانشاه", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 23, Name = "کهگیلویه و بویراحمد", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 24, Name = "گلستان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 25, Name = "گیلان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 26, Name = "لرستان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 27, Name = "مازندران", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 28, Name = "مرکزی", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 29, Name = "هرمزگان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 30, Name = "همدان", CreatedAt = DateTime.Now, IsDeleted = false, },
               new City { Id = 31, Name = "یزد", CreatedAt = DateTime.Now, IsDeleted = false, }
           );
        }
    }
}
