using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplikacijaZaPrijavuIzgradnjeKuca.Data;
using AplikacijaZaPrijavuOstecenjaSisMosZup.Models;

namespace AplikacijaZaPrijavuIzgradnjeKuca.Controllers
{
    public class PrijaviteljController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrijaviteljController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prijavitelj
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prijavitelj.ToListAsync());
        }

        // GET: Prijavitelj/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavitelj = await _context.Prijavitelj
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prijavitelj == null)
            {
                return NotFound();
            }

            return View(prijavitelj);
        }

        // GET: Prijavitelj/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prijavitelj/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImeVlasnikaTvrtke,PrezimeVlasnikaTvrtke,ImeTvrtke,BrojGodinaPoslovanja,OIBTvrtke,Adresa,Email,KontaktBroj,BrojRadnika")] Prijavitelj prijavitelj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prijavitelj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prijavitelj);
        }

        // GET: Prijavitelj/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavitelj = await _context.Prijavitelj.FindAsync(id);
            if (prijavitelj == null)
            {
                return NotFound();
            }
            return View(prijavitelj);
        }

        // POST: Prijavitelj/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImeVlasnikaTvrtke,PrezimeVlasnikaTvrtke,ImeTvrtke,BrojGodinaPoslovanja,OIBTvrtke,Adresa,Email,KontaktBroj,BrojRadnika")] Prijavitelj prijavitelj)
        {
            if (id != prijavitelj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prijavitelj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrijaviteljExists(prijavitelj.Id))
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
            return View(prijavitelj);
        }

        // GET: Prijavitelj/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavitelj = await _context.Prijavitelj
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prijavitelj == null)
            {
                return NotFound();
            }

            return View(prijavitelj);
        }

        // POST: Prijavitelj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prijavitelj = await _context.Prijavitelj.FindAsync(id);
            _context.Prijavitelj.Remove(prijavitelj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrijaviteljExists(int id)
        {
            return _context.Prijavitelj.Any(e => e.Id == id);
        }
    }
}
