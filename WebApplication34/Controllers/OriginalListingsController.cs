using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
    public class OriginalListingsController : Controller
    {
        private readonly SecuritiStockContext _context;

        public OriginalListingsController(SecuritiStockContext context)
        {
            _context = context;
        }

        // GET: OriginalListings
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            var data = _context.OriginalListing.AsQueryable();

            return View(await PaginatedList<OriginalListing>.CreateAsync(data.AsNoTracking(), pageNumber, 20));
        }

        // GET: OriginalListings/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalListing = await _context.OriginalListing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (originalListing == null)
            {
                return NotFound();
            }

            return View(originalListing);
        }

        // GET: OriginalListings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OriginalListings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OriginalListing originalListing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(originalListing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(originalListing);
        }

        // GET: OriginalListings/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalListing = await _context.OriginalListing.FindAsync(id);
            if (originalListing == null)
            {
                return NotFound();
            }
            return View(originalListing);
        }

        // POST: OriginalListings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, OriginalListing originalListing)
        {
            if (id != originalListing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(originalListing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OriginalListingExists(originalListing.Id))
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
            return View(originalListing);
        }

        // GET: OriginalListings/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalListing = await _context.OriginalListing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (originalListing == null)
            {
                return NotFound();
            }

            return View(originalListing);
        }

        // POST: OriginalListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var originalListing = await _context.OriginalListing.FindAsync(id);
            _context.OriginalListing.Remove(originalListing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OriginalListingExists(long id)
        {
            return _context.OriginalListing.Any(e => e.Id == id);
        }
        public IActionResult Import()
        {
            return View(new ImportVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Import(ImportVM formFile)
        {
            var batch = _context.OriginalListing.OrderByDescending(v => v.Batch).Where(c => c.Year == formFile.Year).FirstOrDefault()?.Batch ?? 0;
            batch++;
            // upload
            var filePath = Path.GetTempFileName();
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await formFile.Myfile.CopyToAsync(stream);
            }

            var list = ExcelComunication.DataTableTooriginal_listing(ExcelComunication.ExcelToDataTable(filePath), formFile.Year, batch);
            _context.OriginalListing.AddRange(list);
            await _context.SaveChangesAsync();
            await _context.Database.ExecuteSqlCommandAsync("init_transaction");
            return RedirectToAction("Index");
        }
    }
}
