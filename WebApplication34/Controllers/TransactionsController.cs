using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication34.Data;
using WebApplication34.Helper;
using WebApplication34.Models;
using WebApplication34.Paging;

namespace WebApplication34.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly SecuritiStockContext _context;
        private readonly IMapper _mapper;
        public TransactionsController(SecuritiStockContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Transactions
        public async Task<IActionResult> Index(string search, string area, string type, string year, int pageNumber = 1, string download = "")
        {
            ViewBag.search = search;
            ViewBag.area = area;
            ViewBag.type = type;
            ViewBag.year = year;
            ViewBag.download = download;
            var data = _context.Transaction.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                data = data.Where(e => e.Cnmd.Contains(search));
            }
            if (string.IsNullOrEmpty(area))
            {
                data = data.Where(e => e.BankAccountId == null);
            }
            else
            {
                data = data.Where(e => e.BankAccountId != null);
            }
            if (type == "not")
            {
                data = data.Where(e => e.IsPaid == false);
            }
            if (type == "yet")
            {
                data = data.Where(e => e.IsPaid == true);
            }
            if (!string.IsNullOrEmpty(year))
            {
                var yearInt = 0;
                    int.TryParse(year, out yearInt);
                data = data.Where(e => e.Year == yearInt);
            }
            return View(await PaginatedList<Transaction>.CreateAsync(data.AsNoTracking(), pageNumber, 20));
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.BankAccount)
                .Include(t => t.Original)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["BankAccountId"] = new SelectList(_context.BankAccount, "Id", "CmndNumber");
            ViewData["OriginalId"] = new SelectList(_context.OriginalListing, "Id", "Id");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cnmd,Type,FullName,ReceiveMoney,Tax,RealRecevieMoney,Created,OriginalId,BankAccountId,IsPaid,PaidDate")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BankAccountId"] = new SelectList(_context.BankAccount, "Id", "CmndNumber", transaction.BankAccountId);
            ViewData["OriginalId"] = new SelectList(_context.OriginalListing, "Id", "Id", transaction.OriginalId);
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            ViewData["BankAccountId"] = new SelectList(_context.BankAccount, "Id", "CmndNumber", transaction.BankAccountId);
            ViewData["OriginalId"] = new SelectList(_context.OriginalListing, "Id", "Id", transaction.OriginalId);
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Cnmd,Type,FullName,ReceiveMoney,Tax,RealRecevieMoney,Created,OriginalId,BankAccountId,IsPaid,PaidDate")] Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BankAccountId"] = new SelectList(_context.BankAccount, "Id", "CmndNumber", transaction.BankAccountId);
            ViewData["OriginalId"] = new SelectList(_context.OriginalListing, "Id", "Id", transaction.OriginalId);
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.BankAccount)
                .Include(t => t.Original)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var transaction = await _context.Transaction.FindAsync(id);
            _context.Transaction.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(long id)
        {
            return _context.Transaction.Any(e => e.Id == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pay(IFormCollection collection, string search, string area)
        {
            string download = "";
            if (ModelState.IsValid)
            {
                try
                {
                    var ls = Request.Form["CheckedIDs"];

                    if (!string.IsNullOrEmpty(ls))
                    {
                        var ids = ls.ToString().Split(',');
                        List<long> myStringList = ids.Select(s => long.Parse(s)).ToList();
                        var data = _context.Transaction.Where(e => myStringList.Contains(e.Id));
                        foreach (var item in data)
                        {
                            item.IsPaid = true;
                            item.PaidDate = DateTime.Now;
                        }
                        await _context.SaveChangesAsync();



                        if (area == "bank")
                        {
                            download = DateTime.Now.ToString("yyyyMMdd") + ".xlsx";
                            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", download);

                            var export = data.Select(c => new TransactionExportVM
                            {
                                bank = c.BankAccount.Bank,
                                beneficiaries = c.BankAccount.Beneficiaries,
                                cmnd_number = c.Cnmd,
                                full_name = c.FullName,
                                get_revc_money = c.ReceiveMoney,
                                get_revc_real_money = c.RealRecevieMoney,
                                number_account = c.BankAccount.NumberAccount,
                                tax = c.Tax
                            }).ToList();

                            ExportExcel.CreateExcelDocument(export, filePath);

                        


                        }
                        else
                        {
                            //tới phiếu chi
                        }
                    }

                }
                catch (DbUpdateConcurrencyException)
                {

                }

                return RedirectToAction("Index", new { search, area,download });
            }
            //ViewData["BankAccountId"] = new SelectList(_context.BankAccount, "Id", "CmndNumber", transaction.BankAccountId);
            //ViewData["OriginalId"] = new SelectList(_context.OriginalListing, "Id", "Id", transaction.OriginalId);
            return View();
        }

        public async Task<IActionResult> Payment(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .Include(t => t.BankAccount)
                .Include(t => t.Original)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }


    }
}
