using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRentalClub.Models;

namespace CarRentalClub.Views.CustomerNames
{
    public class CustomerNamesController : Controller
    {
        private readonly ReservationDb _context;

        public CustomerNamesController(ReservationDb context)
        {
            _context = context;
        }

        // GET: CustomerNames
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerName.ToListAsync());
        }

        // GET: CustomerNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerName = await _context.CustomerName
                .FirstOrDefaultAsync(m => m.CustomerNameId == id);
            if (customerName == null)
            {
                return NotFound();
            }

            return View(customerName);
        }

        // GET: CustomerNames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerNames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerNameId,Name,Address,PhoneNumber")] CustomerName customerName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerName);
        }

        // GET: CustomerNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerName = await _context.CustomerName.FindAsync(id);
            if (customerName == null)
            {
                return NotFound();
            }
            return View(customerName);
        }

        // POST: CustomerNames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerNameId,Name,Address,PhoneNumber")] CustomerName customerName)
        {
            if (id != customerName.CustomerNameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerName);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerNameExists(customerName.CustomerNameId))
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
            return View(customerName);
        }

        // GET: CustomerNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerName = await _context.CustomerName
                .FirstOrDefaultAsync(m => m.CustomerNameId == id);
            if (customerName == null)
            {
                return NotFound();
            }

            return View(customerName);
        }

        // POST: CustomerNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerName = await _context.CustomerName.FindAsync(id);
            _context.CustomerName.Remove(customerName);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerNameExists(int id)
        {
            return _context.CustomerName.Any(e => e.CustomerNameId == id);
        }
    }
}
