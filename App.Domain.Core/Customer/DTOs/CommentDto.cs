using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
		[Required(ErrorMessage = "توضیحات شما الزامی است")]
		public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsConfirmed { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
		public int Rate { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerImageUrl { get; set; }
        public int ExpertId { get; set; }
        public string? ExpertName { get; set; }
        public int AdminId { get; set; }
        public string? AdminName { get; set; }
        public int ServiceRequestId { get; set; }
        public string? ServiceName { get; set; }
    }
}
