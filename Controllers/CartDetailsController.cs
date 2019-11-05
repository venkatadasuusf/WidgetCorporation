using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WidgetCorporation.Data;
using WidgetCorporation.Models;

namespace WidgetCorporation.Controllers
{
    public class CartDetailsController : Controller
    {
        private readonly WidgetCorporationDBContext _context;

        public CartDetailsController(WidgetCorporationDBContext context)
        {
            _context = context;
        }

        // GET: CartDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartDetails.ToListAsync());
        }

        // GET: CartDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartDetails = await _context.CartDetails
                .FirstOrDefaultAsync(m => m.CartDetSeqID == id);
            if (cartDetails == null)
            {
                return NotFound();
            }

            return View(cartDetails);
        }

        // GET: CartDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CartDetSeqID,CartID,ProductID,ProductQuantity")] CartDetails cartDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartDetails);
        }

        // GET: CartDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartDetails = await _context.CartDetails.FindAsync(id);
            if (cartDetails == null)
            {
                return NotFound();
            }
            return View(cartDetails);
        }

        // POST: CartDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CartDetSeqID,CartID,ProductID,ProductQuantity")] CartDetails cartDetails)
        {
            if (id != cartDetails.CartDetSeqID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartDetailsExists(cartDetails.CartDetSeqID))
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
            return View(cartDetails);
        }

        // GET: CartDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartDetails = await _context.CartDetails
                .FirstOrDefaultAsync(m => m.CartDetSeqID == id);
            if (cartDetails == null)
            {
                return NotFound();
            }

            return View(cartDetails);
        }

        // POST: CartDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartDetails = await _context.CartDetails.FindAsync(id);
            _context.CartDetails.Remove(cartDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartDetailsExists(int id)
        {
            return _context.CartDetails.Any(e => e.CartDetSeqID == id);
        }
    }
}
