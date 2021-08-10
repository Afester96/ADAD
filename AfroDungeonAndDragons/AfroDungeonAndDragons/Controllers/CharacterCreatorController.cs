using AfroDungeonAndDragons.Models;
using AfroDungeonAndDragons.Models.CharacterCreator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class CharacterCreatorController : Controller
    {
        private ApplicationContext db;
        public CharacterCreatorController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Races()
        {
            return View(await db.Races.ToListAsync());
        }
        public IActionResult CreateRace()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRace(Race race)
        {
            db.Races.Add(race);
            await db.SaveChangesAsync();
            return RedirectToAction("Races");
        }
        public async Task<IActionResult> AboutRace(int? id)
        {
            if (id != null)
            {
                Race race = await db.Races.FirstOrDefaultAsync(r => r.Id == id);
                return View(race);
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRace(int? id)
        {
            if (id != null)
            {
                Race race = await db.Races.FirstOrDefaultAsync(r => r.Id == id);
                if (race != null)
                {
                    return View(race);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRace(Race race)
        {
            db.Races.Update(race);
            await db.SaveChangesAsync();
            return RedirectToAction("Races");
        }
        [HttpGet]
        [ActionName("DeleteRace")]
        public async Task<IActionResult> ConfirmDeleteRace(int? id)
        {
            if (id != null)
            {
                Race race = await db.Races.FirstOrDefaultAsync(r => r.Id == id);
                if (race != null)
                {
                    return View(race);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRace(int? id)
        {
            if (id != null)
            {
                Race race = await db.Races.FirstOrDefaultAsync(r => r.Id == id);
                if (true)
                {
                    db.Races.Remove(race);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Races");
                }
            }
            return NotFound();
        }
    }
}
