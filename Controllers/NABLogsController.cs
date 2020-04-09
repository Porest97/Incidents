using System;
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
    public class NABLogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NABLogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NABLogs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.NABLog
                .Include(n => n.Incident)
                .Include(n => n.WLog);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: NABLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nABLog = await _context.NABLog
                .Include(n => n.Incident)
                .Include(n => n.WLog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nABLog == null)
            {
                return NotFound();
            }

            return View(nABLog);
        }

        // GET: NABLogs/Create
        public IActionResult Create()
        {
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "IncidentNumber");
            ViewData["WLogId"] = new SelectList(_context.WLog, "Id", "WLNumber");
            return View();
        }

        // POST: NABLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IncidentId,DateTimeStarted,DateTimeEnded,LogNotes,Hours,PriceHour,MtrCost,TotalCost,WLogId")] NABLog nABLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nABLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "IncidentNumber", nABLog.IncidentId);
            ViewData["WLogId"] = new SelectList(_context.WLog, "Id", "WLNumber", nABLog.WLogId);
            return View(nABLog);
        }

        // GET: NABLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nABLog = await _context.NABLog.FindAsync(id);
            if (nABLog == null)
            {
                return NotFound();
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "IncidentNumber", nABLog.IncidentId);
            ViewData["WLogId"] = new SelectList(_context.WLog, "Id", "WLNumber", nABLog.WLogId);
            return View(nABLog);
        }

        // POST: NABLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IncidentId,DateTimeStarted,DateTimeEnded,LogNotes,Hours,PriceHour,MtrCost,TotalCost,WLogId")] NABLog nABLog)
        {
            if (id != nABLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nABLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NABLogExists(nABLog.Id))
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
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "IncidentNumber", nABLog.IncidentId);
            ViewData["WLogId"] = new SelectList(_context.WLog, "Id", "WLNumber", nABLog.WLogId);
            return View(nABLog);
        }

        // GET: NABLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nABLog = await _context.NABLog
                .Include(n => n.Incident)
                .Include(n => n.WLog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nABLog == null)
            {
                return NotFound();
            }

            return View(nABLog);
        }

        // POST: NABLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nABLog = await _context.NABLog.FindAsync(id);
            _context.NABLog.Remove(nABLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NABLogExists(int id)
        {
            return _context.NABLog.Any(e => e.Id == id);
        }
    }
}
