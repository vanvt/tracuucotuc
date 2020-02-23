using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication34.Data;
using WebApplication34.Helper;
using WebApplication34.Models;
using WebApplication34.Paging;

namespace WebApplication34.Controllers
{
    public class BankAccountsController : Controller
    {
        private readonly SecuritiStockContext _context;

        public BankAccountsController(SecuritiStockContext context)
        {
            _context = context;
        }

        // GET: BankAccounts
        public async Task<IActionResult> Index(string search,int pageNumber = 1)
        {
            ViewBag.search = search;
            var data = _context.BankAccount.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                data = data.Where(e => e.CmndNumber.Contains(search));
            }
            return View(await PaginatedList<BankAccount>.CreateAsync(data.AsNoTracking(), pageNumber, 20));
        }

        // GET: BankAccounts/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.BankAccount
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return View(bankAccount);
        }

        // GET: BankAccounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BankAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CmndNumber,Beneficiaries,NumberAccount,Bank,Created,Updated,CreatedBy,UpdateBy")] BankAccount bankAccount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankAccount);
                await _context.SaveChangesAsync();
                await _context.Database.ExecuteSqlCommandAsync("modify_banks_transaction");
                return RedirectToAction(nameof(Index));
            }
            return View(bankAccount);
        }

        // GET: BankAccounts/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.BankAccount.FindAsync(id);
            if (bankAccount == null)
            {
                return NotFound();
            }
            return View(bankAccount);
        }

        // POST: BankAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,CmndNumber,Beneficiaries,NumberAccount,Bank,Created,Updated,CreatedBy,UpdateBy")] BankAccount bankAccount)
        {
            if (id != bankAccount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankAccountExists(bankAccount.Id))
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
            return View(bankAccount);
        }

        // GET: BankAccounts/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.BankAccount
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return View(bankAccount);
        }

        // POST: BankAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var bankAccount = await _context.BankAccount.FindAsync(id);
            _context.BankAccount.Remove(bankAccount);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankAccountExists(long id)
        {
            return _context.BankAccount.Any(e => e.Id == id);
        }
        public IActionResult Import()
        {
            return View(new ImportVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Import(ImportVM formFile)
        {
            // upload
            var filePath = Path.GetTempFileName();
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await formFile.Myfile.CopyToAsync(stream);
            }

            var list = ExcelComunication.DataTableToBankAccount(ExcelComunication.ExcelToDataTable(filePath));
            _context.BankAccount.AddRange(list);
            await _context.SaveChangesAsync();
            await _context.Database.ExecuteSqlCommandAsync("modify_banks_transaction");
            return RedirectToAction("Index");
        }
    }
}
