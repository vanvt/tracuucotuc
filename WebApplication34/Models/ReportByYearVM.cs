using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication34.Models
{
    public class ReportByYearVM
    {
        public decimal? tienMat_tien { get; set; }
        public decimal? tienMat_cd { get; set; }
        public decimal? chuyenKhoan_tien { get; set; }
        public decimal? chuyenKhoan_cd { get; set; }
        public decimal? tong_tien { get; set; }
        public decimal? tong_cd { get; set; }
        public int Year { get; set; }
    }
    public class ReportByYearListVM
    {
        public ReportByYearListVM()
        {
            //PaidReport = new Queryable<ReportByYearVM>();
            //RemainReport = new Queryable<ReportByYearVM>();
        }
        public IQueryable<ReportByYearVM> PaidReport { get; set; }
        public IQueryable<ReportByYearVM> RemainReport { get; set; }
    }
}
