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
            if (User.IsInRole("User"))
            {
                if (db.Backgrounds.Where(n => n.User.Login == User.Identity.Name).Count() >= 0)
                {
                    return View("../Homebrew/RaceCreator/Races", await db.Races.Where(n => n.User.Login == User.Identity.Name).ToListAsync());
                }
                else
                    return RedirectToAction("BestRaces");
            }
            if (User.IsInRole("Admin"))
            {
                return View("../Homebrew/RaceCreator/Races", await db.Races.ToListAsync());
            }
            return RedirectToAction("BestRaces");
        }

        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> BestRaces()
        {
            return View("../Homebrew/RaceCreator/Races", await db.Races.Where(r => r.Best == true).ToListAsync());
        }

        [Authorize(Roles = "Admin, User")]
        public IActionResult CreateRace()
        {
            return View("../Homebrew/RaceCreator/CreateRace");
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> CreateRace(Race race)
        {
            if (ModelState.IsValid)
            {
                race.User = await db.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
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

        [Authorize(Roles = "Admin, User")]
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

        [Authorize(Roles = "Admin, User")]
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

        [Authorize(Roles = "Admin, User")]
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

        [Authorize(Roles = "Admin, User")]
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
