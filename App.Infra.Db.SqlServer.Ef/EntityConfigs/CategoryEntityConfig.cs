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
                new Category { Id = 1, Title = "دکوراسیون ساختمان", Image = "/assets/img/category/دکوراسیون-ساختمان.png", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 2, Title = "تاسیسات ساختمان", Image = "/assets/img/category/تاسیسات-ساختمان.jpg", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 3, Title = "وسایل نقلیه", Image = "/assets/img/category/وسایل-نقلیه.jpg", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 4, Title = "اسباب کشی و باربری", Image = "/assets/img/category/اسباب-کشی-و-باربری.jpg", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 5, Title = "لوازم خانگی", Image = "/assets/img/category/لوازم-خانگی.png", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 6, Title = "خدمات اداری", Image = "/assets/img/category/خدمات-اداری.jpg", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 7, Title = "دیجیتال و نرم افزار", Image = "/assets/img/category/دیجیتال-و-نرم-افزار.jpg", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 8, Title = "نظافت و بهداشت", Image = "/assets/img/category/نظافت-و-بهداشت.jpg", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" },
                new Category { Id = 9, Title = "پزشکی و سلامت", Image = "/assets/img/category/پزشکی-و-سلامت.jpg", CreatedAt = DateTime.Now, IsDeleted = false, Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است" }
                );
        }
    }
}
