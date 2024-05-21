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
    public class CategoryEntityConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(c => c.Id);
            builder
                .Property(c => c.Title)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(c => c.Image)
                .HasMaxLength(4000);
            builder
                .Property(c => c.Description)
                .HasMaxLength(4000)
                .IsRequired();
            builder
                .Property(c => c.CreatedAt)
                .IsRequired();
            builder
                .Property(c => c.IsDeleted)
                .IsRequired();


            builder.HasData(
                new Category { Id = 1, Title = "دکوراسیون ساختمان", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 2, Title = "تاسیسات ساختمان", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 3, Title = "وسایل نقلیه", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 4, Title = "اسباب کشی و باربری", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 5, Title = "لوازم خانگی", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 6, Title = "خدمات اداری", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 7, Title = "دیجیتال و نرم افزار", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 8, Title = "نظافت و بهداشت", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " },
                new Category { Id = 9, Title = "پزشکی و سلامت", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم " }
                );
        }
    }
}
