using System;
using System.Collections.Generic;

namespace WebApplication34.Data
{
    public partial class Transaction
    {
        public long Id { get; set; }
        public string Cnmd { get; set; }
        public string Type { get; set; }
        public string FullName { get; set; }
        public decimal? ReceiveMoney { get; set; }
        public decimal? Tax { get; set; }
        public decimal? RealRecevieMoney { get; set; }
        public DateTime? Created { get; set; }
        public long OriginalId { get; set; }
        public long? BankAccountId { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int? Batch { get; set; }
        public int? Year { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual OriginalListing Original { get; set; }
    }
}
