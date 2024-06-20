using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
	public class LoginDto
	{

		[Required(ErrorMessage = "وارد کردن رمزعبور اجباری است")]
		[MinLength(4, ErrorMessage = "رمزعبور نمی‌تواند کمتر 4 کاراکتر باشد")]
		public string Password { get; set; }
		[Required(ErrorMessage = "وارد کردن یوزرنیم اجباری است")]
		[EmailAddress(ErrorMessage = "فرمت ایمیل اشتباه است")]
		[Length(10, 50, ErrorMessage = "یوزرنیم نمی‌تواند کمتر 10 و بیشتر از 50 کاراکتر باشد")]
		public string UserName { get; set; }
	}
}
