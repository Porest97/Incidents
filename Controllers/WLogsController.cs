﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Incidents.Data;
using Incidents.Models.DataModels;

namespace Incidents.Controllers
{
    public class WLogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WLogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WLogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.WLog.ToListAsync());
        }

        // GET: WLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wLog = await _context.WLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wLog == null)
            {
                return NotFound();
            }

            return View(wLog);
        }

        // GET: WLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WLNumber,Hours,DateTimeFrom,DateTimeTo,Subject")] WLog wLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wLog);
        }

        // GET: WLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wLog = await _context.WLog.FindAsync(id);
            if (wLog == null)
            {
                return NotFound();
            }
            return View(wLog);
        }

        // POST: WLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WLNumber,Hours,DateTimeFrom,DateTimeTo,Subject")] WLog wLog)
        {
            if (id != wLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WLogExists(wLog.Id))
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
            return View(wLog);
        }

        // GET: WLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wLog = await _context.WLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wLog == null)
            {
                return NotFound();
            }

            return View(wLog);
        }

        // POST: WLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wLog = await _context.WLog.FindAsync(id);
            _context.WLog.Remove(wLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WLogExists(int id)
        {
            return _context.WLog.Any(e => e.Id == id);
        }
    }
}
