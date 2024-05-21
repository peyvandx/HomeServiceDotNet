﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Enums
{
    public enum Status
    {
        [Display(Name = "درانتظار درخواست‌های متخصصان")]
        WaitingForExpertsProposals = 0,
        [Display(Name = "درانتظار پذیرش یکی از درخواست‌های متخصصان")]
        WaitingForAcceptAProposal = 1,
        [Display(Name = "درانتظار مراجعه متخصص")]
        WaitingForExpert = 2,
        [Display(Name = "با‌موفقیت انجام‌شد")]
        Success = 3,
        [Display(Name = "انجام‌نشد")]
        Failed = 4,
        [Display(Name = "کنسل‌شد")]
        Canceled = 5,
    }
}
