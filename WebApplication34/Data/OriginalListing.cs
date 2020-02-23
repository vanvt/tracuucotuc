using System;
using System.Collections.Generic;

namespace WebApplication34.Data
{
    public partial class OriginalListing
    {
        public OriginalListing()
        {
            Transaction = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string FullName { get; set; }
        public string CmndNumber { get; set; }
        public string CmndIssueDay { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public decimal? NumberStockDeposited { get; set; }
        public decimal? NumberStockNotDeposite { get; set; }
        public decimal? NumberStockTotal { get; set; }
        public decimal? DividendDeposited { get; set; }
        public decimal? DividendNotDeposite { get; set; }
        public decimal? DividendTotal { get; set; }
        public decimal? TaxDeposited { get; set; }
        public decimal? TaxNotDeposite { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? DividendReceivedDeposited { get; set; }
        public decimal? DividendReceivedNotDeposite { get; set; }
        public decimal? DividendReceivedTotal { get; set; }
        public string Type { get; set; }
        public string AssignmentOrganization { get; set; }
        public string Txnum { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public int? Year { get; set; }
        public int? Batch { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdateBy { get; set; }
        public string Tesss { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
