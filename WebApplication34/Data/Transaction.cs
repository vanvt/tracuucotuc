using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication34.Data
{
    public partial class Transaction
    {
        public long Id { get; set; }
        [Display(Name = "Số CMND")]
        public string Cnmd { get; set; }
        public string Type { get; set; }
        [Display(Name ="Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Số tiền nhận")]
        public decimal? ReceiveMoney { get; set; }
        [Display(Name = "Số tiền chịu thuế")]
        public decimal? Tax { get; set; }
        [Display(Name = "Thực nhận")]
        public decimal? RealRecevieMoney { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? Created { get; set; }
        public long OriginalId { get; set; }
        public long? BankAccountId { get; set; }
        [Display(Name = "Tình trạng thanh toán")]
        public bool IsPaid { get; set; }
        [Display(Name = "Ngày thanh toán")]
        public DateTime? PaidDate { get; set; }
        [Display(Name = "Đợt")]
        public int? Batch { get; set; }
        [Display(Name = "Năm")]
        public int? Year { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual OriginalListing Original { get; set; }
    }
}
