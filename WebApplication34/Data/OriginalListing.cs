using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication34.Data
{
    public partial class OriginalListing
    {
        public OriginalListing()
        {
            Transaction = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        [Display(Name = "HỌ TÊN")]
        public string FullName { get; set; }
        [Display(Name = "SỐ ĐKSH")]
        public string CmndNumber { get; set; }
        [Display(Name = "NGÀY CẤP")]
        public string CmndIssueDay { get; set; }
        [Display(Name = "ĐỊA CHỈ LIÊN HỆ")]
        public string Address { get; set; }

        [Display(Name = "QUỐC TỊCH")]
        public string Country { get; set; }

        [Display(Name = "SỐ CP CHƯA LK")]
        public decimal? NumberStockDeposited { get; set; }
        [Display(Name = "SỐ CP ĐÃ LK")]
        public decimal? NumberStockNotDeposite { get; set; }
        [Display(Name = "CỘNG SỐ CP")]
        public decimal? NumberStockTotal { get; set; }
        [Display(Name = "CHƯA LK (TRƯỚC THUẾ)")]
        public decimal? DividendDeposited { get; set; }
        [Display(Name = "ĐÃ LK (TRƯỚC THUẾ)")]
        public decimal? DividendNotDeposite { get; set; }
        [Display(Name = "CỘNG (TRƯỚC THUẾ)")]
        public decimal? DividendTotal { get; set; }
        [Display(Name = "CHƯA LK (THUẾ)")]
        public decimal? TaxDeposited { get; set; }
        [Display(Name = "ĐÃ LK (THUẾ)")]
        public decimal? TaxNotDeposite { get; set; }
        [Display(Name = "CỘNG (THUẾ)")]
        public decimal? TaxTotal { get; set; }
        [Display(Name = "CHƯA LK(SAU THUẾ)")]
        public decimal? DividendReceivedDeposited { get; set; }
        [Display(Name = "ĐÃ LK(SAU THUẾ)")]
        public decimal? DividendReceivedNotDeposite { get; set; }
        [Display(Name = "CỘNG(SAU THUẾ)")]
        public decimal? DividendReceivedTotal { get; set; }
        [Display(Name = "TYPE")]
        public string Type { get; set; }
        [Display(Name = "CNTC")]
        public string AssignmentOrganization { get; set; }
        [Display(Name = "TXNUM")]
        public string Txnum { get; set; }
        [Display(Name = "EMAIL")]
        public string Email { get; set; }
        [Display(Name = "ĐIỆN THOẠI")]
        public string Phone { get; set; }
        [Display(Name = "GHI CHÚ")]
        public string Note { get; set; }
        [Display(Name = "NĂM")]
        public int? Year { get; set; }
        [Display(Name = "ĐỢT")]
        public int? Batch { get; set; }
        [Display(Name = "NGÀY TẠO")]
        public DateTime? Created { get; set; }
        [Display(Name = "CẬP NHẬT")]
        public DateTime? Updated { get; set; }
        [Display(Name = "TẠO BỞI")]
        public string CreatedBy { get; set; }
        [Display(Name = "CẬP NHẬT BỞI")]
        public string UpdateBy { get; set; }
        public string Tesss { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
