using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.EntityConfigs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Microsoft.EntityFrameworkCore.DbContext

namespace App.Infra.Db.SqlServer.Ef.DbContext
{
    public class HomeServiceDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public HomeServiceDbContext(DbContextOptions<HomeServiceDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminEntityConfig());
            modelBuilder.ApplyConfiguration(new  ExpertEntityConfig());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfig());
            modelBuilder.ApplyConfiguration(new CommentEntityConfig());
            modelBuilder.ApplyConfiguration(new ProposalEntityConfig());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfig());
            modelBuilder.ApplyConfiguration(new ServiceEntityConfig());
            modelBuilder.ApplyConfiguration(new ServiceRequestEntityConfig());
            modelBuilder.ApplyConfiguration(new AddressEntityConfig());
            modelBuilder.ApplyConfiguration(new SkillEntityConfig());
            modelBuilder.ApplyConfiguration(new CityEntityConfig());
            //modelBuilder.ApplyConfiguration(new ProvinceEntityConfig());

            UserConfigurations.SeedUsers(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<City> Cities { get; set; }
        //public DbSet<Province> Provinces { get; set; }

    }
}
