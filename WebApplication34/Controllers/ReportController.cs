using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication34.Data;
using WebApplication34.Models;
using WebApplication34.Paging;

namespace WebApplication34.Controllers
{
    public class ReportController : Controller
    {
        SecuritiStockContext _context;
        public ReportController(SecuritiStockContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ReportByYearListVM reportByYearListVM = new ReportByYearListVM();

            var data = _context.Transaction.Where(e => e.IsPaid).GroupBy(e => e.Year).Select(e => new ReportByYearVM
            {
                chuyenKhoan_cd = e.Where(c => c.BankAccount != null).Count(),
                chuyenKhoan_tien = e.Where(c => c.BankAccount != null).Sum(v => v.ReceiveMoney),
                tienMat_cd = e.Where(c => c.BankAccount == null).Count(),
                tienMat_tien = e.Where(c => c.BankAccount == null).Sum(v => v.ReceiveMoney),
                tong_cd = e.Count(),
                tong_tien = e.Sum(v => v.ReceiveMoney),
                Year = e.Key.Value
            });
            var data1 = _context.Transaction.Where(e => e.IsPaid == false).GroupBy(e => e.Year).Select(e => new ReportByYearVM
            {
                chuyenKhoan_cd = e.Where(c => c.BankAccountId != null).Count(),
                chuyenKhoan_tien = e.Where(c => c.BankAccountId != null).Sum(v => v.ReceiveMoney),
                tienMat_cd = e.Where(c => c.BankAccountId == null).Count(),
                tienMat_tien = e.Where(c => c.BankAccountId == null).Sum(v => v.ReceiveMoney),
                tong_cd = e.Count(),
                tong_tien = e.Sum(v => v.ReceiveMoney),
                Year = e.Key.Value
            });

            reportByYearListVM.PaidReport = data;
            reportByYearListVM.RemainReport = data1;
            return View(reportByYearListVM);
        }
    }
}