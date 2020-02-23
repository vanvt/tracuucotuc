using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication34.Models
{
    public class TransactionExportVM
    {
        [Display(Name = "Số CMND")]
        public string cmnd_number { get; set; }
        [Display(Name = "Họ và tên")]
        public string full_name { get; set; }
        [Display(Name = "Người hưởng thụ")]
        public string beneficiaries { get; set; }
        [Display(Name = "Số tài khoản")]
        public string number_account { get; set; }
        [Display(Name = "Ngân hàng")]
        public string bank { get; set; }
        [Display(Name = "Cổ tức")]
        public Nullable<decimal> get_revc_money { get; set; }
        [Display(Name = "Thuế")]
        public Nullable<decimal> tax { get; set; }
        [Display(Name = "Còn nhận được")]
        public Nullable<decimal> get_revc_real_money { get; set; }

    }
}
