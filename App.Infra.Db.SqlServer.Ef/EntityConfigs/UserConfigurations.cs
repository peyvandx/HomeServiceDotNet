using App.Domain.Core.Admin.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Ef.EntityConfigs
{
	public class UserConfigurations
	{
		public static void SeedUsers(ModelBuilder builder)
		{
			var hasher = new PasswordHasher<ApplicationUser>();

			// SeedUsers
			var users = new List<ApplicationUser>
		{
			new ApplicationUser()
			{
				Id = 1,
				UserName = "Admin@gmail.com",
				NormalizedUserName = "ADMIN@GMAIL.COM",
				Email = "Admin@gmail.com",
				NormalizedEmail = "ADMIN@GMAIL.COM",
				LockoutEnabled = false,
				PhoneNumber = "09377507920",
				AdminId = 1,
				SecurityStamp = Guid.NewGuid().ToString()
			},
			new ApplicationUser()
			{
				Id = 2,
				UserName = "Ali@gmail.com",
				NormalizedUserName = "ALI@GMAIL.COM",
				Email = "Ali@gmail.com",
				NormalizedEmail = "ALI@GMAIL.COM",
				LockoutEnabled = false,
				PhoneNumber = "09377507920",
				CustomerId = 2,
				SecurityStamp = Guid.NewGuid().ToString()
			},
			new ApplicationUser()
			{
				Id = 3,
				UserName = "Sahar@gmail.com",
				NormalizedUserName = "SAHAR@GMAIL.COM",
				Email = "Sahar@gmail.com",
				NormalizedEmail = "SAHAR@GMAIL.COM",
				LockoutEnabled = false,
				PhoneNumber = "09377507920",
				CustomerId = 3,
				SecurityStamp = Guid.NewGuid().ToString()
			},
			new ApplicationUser()
			{
				Id = 4,
				UserName = "Maryam@gmail.com",
				NormalizedUserName = "MARYAM@GMAIL.COM",
				Email = "Maryam@gmail.com",
				NormalizedEmail = "MARYAM@GMAIL.COM",
				LockoutEnabled = false,
				PhoneNumber = "09377507920",
				CustomerId = 4,
				SecurityStamp = Guid.NewGuid().ToString()
			}
		};

			foreach (var user in users)
			{
				var passwordHasher = new PasswordHasher<ApplicationUser>();
				user.PasswordHash = passwordHasher.HashPassword(user, "1234");

				builder.Entity<ApplicationUser>().HasData(user);
			}

			//Seed Role To Users
			builder.Entity<IdentityRole<int>>().HasData(
				new IdentityRole<int>() { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
				new IdentityRole<int>() { Id = 2, Name = "Expert", NormalizedName = "EXPERT" },
				new IdentityRole<int>() { Id = 3, Name = "Customer", NormalizedName = "CUSTOMER" }
			);

			// Seed Roles
			builder.Entity<IdentityUserRole<int>>().HasData(
				new IdentityUserRole<int>() { RoleId = 1, UserId = 1 },
				new IdentityUserRole<int>() { RoleId = 3, UserId = 2 },
				new IdentityUserRole<int>() { RoleId = 3, UserId = 3 },
				new IdentityUserRole<int>() { RoleId = 3, UserId = 4 }
			);
		}
	}
}
