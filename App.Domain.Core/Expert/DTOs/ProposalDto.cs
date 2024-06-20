using App.Domain.Core.Customer.Enums;
using App.Domain.Core.Expert.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ProposalDto
    {
        public int? Id { get; set; }
		[Required(ErrorMessage = "توضیحات شما الزامی است")]
		public string? ExpertDescription { get; set; }
		[Required(ErrorMessage = "وارد کردن قیمت الزامی است")]
		public double? ExpertSuggestedPrice { get; set; }
        public DateTime? ProposalCreatedAt { get; set; }
        public string? ExpertEmail { get; set; }
        public string? ExpertPhoneNumber { get; set; }
        public int? ExpertId { get; set; }
        //public Expert.Entities.Expert Expert { get; set; }
        public string? ExpertFirstName { get; set; }
        public string? ExpertLastName { get; set; }
        public string? ExpertProfileImage { get; set; }
        public DateTime? ExpertSignUpDate { get; set; }
        public string? CustomerDescription { get; set; }
        public double? CustomerSuggestedPrice { get; set; }
        public DateTime? ServiceRequestCreatedAt { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhoneNumber { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public string? CustomerProfileImage { get; set; }
        public DateTime? CustomerSignUpDate { get; set; }
        public int? ServiceRequestId { get; set; }
        public bool? IsAccepted { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsRejected { get; set; }
        public bool ServiceRequestIsDeleted { get; set; }
        public ProposalStatus ProposalStatus { get; set; }
        public ServiceRequestStatus ServiceRequestStatus { get; set; }
        public string? ServiceName { get; set; }
        public string? CategoryName { get; set; }
    }
}
