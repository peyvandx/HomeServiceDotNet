using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Enums
{
    public enum ProposalStatus
    {
        [Display(Name = "درانتظار تایید مشتری")]
        WaitingForCustomerConfirmation = 0,
        [Display(Name = "توسط مشتری کنسل شد")]
        CancelledByCustomer = 1,
        [Display(Name = "درانتظار مراجعه متخصص")]
        WaitingForExpert = 2,
        [Display(Name = "با‌موفقیت انجام‌شد")]
        Success = 3,
        [Display(Name = "با‌موفقیت انجام‌نشد")]
        Failed = 4,
        [Display(Name = "کنسل‌شد")]
        Cancelled = 5,
        [Display(Name = "ردشد")] // if 'IsAccepted' is false
        Rejected = 6,
        [Display(Name = "پیشنهاد دیگری پذیرفته‌شد")] //if 'IsRejected' is true
        NotAccepted = 7,
    }
}
