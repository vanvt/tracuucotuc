using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication34.Data;
using WebApplication34.Models;

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
            var data = new ReportVM
            {
                tongDachi_tien = _context.Transaction.Where(e => e.IsPaid).Sum(e => e.ReceiveMoney),
                chuyenKhoanConlai_cd = _context.Transaction.Where(e => e.IsPaid==false).Where(e=>e.BankAccountId!=null).Count(),
                chuyenKhoanConlai_tien = _context.Transaction.Where(e => e.IsPaid == false).Where(e => e.BankAccountId != null).Sum(e => e.ReceiveMoney),
                chuyenKhoanDachi_cd = _context.Transaction.Where(e => e.IsPaid == true).Where(e => e.BankAccountId != null).Count(),
                chuyenKhoanDachi_tien = _context.Transaction.Where(e => e.IsPaid == true).Where(e => e.BankAccountId != null).Sum(e => e.ReceiveMoney),
                tienMatConlai_cd = _context.Transaction.Where(e => e.IsPaid == false).Where(e => e.BankAccountId == null).Count(),
                tienMatConlai_tien = _context.Transaction.Where(e => e.IsPaid == false).Where(e => e.BankAccountId == null).Sum(e => e.ReceiveMoney),
                tienMatDachi_cd = _context.Transaction.Where(e => e.IsPaid == true).Where(e => e.BankAccountId == null).Count(),
                tienMatDachi_tien = _context.Transaction.Where(e => e.IsPaid == true).Where(e => e.BankAccountId == null).Sum(e => e.ReceiveMoney),
                tongConlai_cd = _context.Transaction.Where(e => e.IsPaid == false).Count(),
                tongConlai_tien = _context.Transaction.Where(e => e.IsPaid == false).Sum(e => e.ReceiveMoney),
                tongDachi_cd = _context.Transaction.Where(e => e.IsPaid == true).Count()
            };
          
            return View(data);
        }
    }
}