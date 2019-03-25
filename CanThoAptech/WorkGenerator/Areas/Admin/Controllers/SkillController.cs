using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkGenerator.Data;
using WorkGenerator.Models;

namespace WorkGenerator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {

        private readonly ApplicationDbContext _db;
        public SkillController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET 
        public async Task<IActionResult> Index()
        {
            return View(await _db.Skill.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Skill skill)
        {
            if (ModelState.IsValid)
            {
                //if valid
                _db.Skill.Add(skill);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            return View(skill);
        }

        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var skill = await _db.Skill.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            return View(skill);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Skill skill)
        {
            if (ModelState.IsValid)
            {
                _db.Update(skill);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }
        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var skill = await _db.Skill.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var skill = await _db.Skill.FindAsync(id);

            if (skill == null)
            {
                return View();
            }
            _db.Skill.Remove(skill);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _db.Skill.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

    }
}
