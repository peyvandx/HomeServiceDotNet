using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "نام الزامی می‌باشد")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "نام خانوادگی الزامی می‌باشد")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "ایمیل الزامی می‌باشد")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل اشتباه است")]
        [Length(10, 50, ErrorMessage = "ایمیل نمی‌تواند کمتر 10 و بیشتر از 50 کاراکتر باشد")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "نام‌کاربری الزامی می‌باشد")]
        //[EmailAddress(ErrorMessage = "نام‌کاربری باید به فرمت ایمیل باشد")]
        //[Length(10, 50, ErrorMessage = "ایمیل نمی‌تواند کمتر 10 و بیشتر از 50 کاراکتر باشد")]
        //public string UserName { get; set; }
        [Required(ErrorMessage = "رمز‌عبور الزامی می‌باشد")]
        [MinLength(6, ErrorMessage = "رمزعبور نمی‌تواند کمتر 6 کاراکتر باشد")]
        public string Password { get; set; }
        [Required(ErrorMessage = "تکرار رمزعبور الزامی می‌باشد")]
        [Compare(nameof(Password), ErrorMessage = "رمزعبور و تایید رمزعبور باهم برابر نیستند")]
        public string ConfirmPassword { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsExpert { get; set; }
    }
}
