using AfroDungeonAndDragons.Models;
using AfroDungeonAndDragons.Models.CharacterCreator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class RaceCreatorController : Controller
    {
        private ApplicationContext db;
        public RaceCreatorController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Races()
        {
            return View("../Homebrew/RaceCreator/Races", await db.Races.ToListAsync());
        }

        [Authorize]
        public IActionResult CreateRace()
        {
            return View("../Homebrew/RaceCreator/CreateRace");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateRace(Race race)
        {
            if (ModelState.IsValid)
            {
                db.Races.Add(race);
                await db.SaveChangesAsync();
                return RedirectToAction("Races");
            }
            else
                return View("../Homebrew/RaceCreator/CreateRace");
        }

        public async Task<IActionResult> AboutRace(int? id)
        {
            if (id != null)
            {
                Race race = await db.Races.FirstOrDefaultAsync(r => r.Id == id);
                return View("../Homebrew/RaceCreator/AboutRace", race);
            }
            return NotFound();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> UpdateRace(int? id)
        {
            if (id != null)
            {
                Race race = await db.Races.FirstOrDefaultAsync(r => r.Id == id);
                if (race != null)
                {
                    return View("../Homebrew/RaceCreator/UpdateRace", race);
                }
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdateRace(Race race)
        {
            if (ModelState.IsValid)
            {
                db.Races.Update(race);
                await db.SaveChangesAsync();
                return RedirectToAction("Races");
            }
            else
                return View("../Homebrew/RaceCreator/UpdateRace");
        }

        [Authorize]
        [HttpGet]
        [ActionName("DeleteRace")]
        public async Task<IActionResult> ConfirmDeleteRace(int? id)
        {
            if (id != null)
            {
                Race race = await db.Races.FirstOrDefaultAsync(r => r.Id == id);
                if (race != null)
                {
                    return View("../Homebrew/RaceCreator/DeleteRace", race);
                }
            }
            return NotFound();
        }

        [Authorize]
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
