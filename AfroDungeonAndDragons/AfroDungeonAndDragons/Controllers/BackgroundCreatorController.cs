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
    public class BackgroundCreatorController : Controller
    {
        private ApplicationContext db;
        public BackgroundCreatorController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Backgrounds()
        {
            if (User.IsInRole("User"))
            {
                if (db.Backgrounds.Where(n => n.User.Login == User.Identity.Name).Count() >= 0)
                {
                    return View("../Homebrew/BackgroundCreator/Backgrounds", await db.Backgrounds.Where(n => n.User.Login == User.Identity.Name).ToListAsync());
                }
                else
                    return RedirectToAction("BestBackgrounds");
            }
            if (User.IsInRole("Admin"))
            {
                return View("../Homebrew/BackgroundCreator/Backgrounds", await db.Backgrounds.ToListAsync());
            }
            return RedirectToAction("BestBackgrounds");
        }

        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> BestBackgrounds()
        {
            return View("../Homebrew/BackgroundCreator/Backgrounds", await db.Backgrounds.Where(r => r.Best == true).ToListAsync());
        }

        [Authorize(Roles = "Admin, User")]
        public IActionResult CreateBackground()
        {
            return View("../Homebrew/BackgroundCreator/CreateBackground");
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> CreateBackground(Background background)
        {
            if (ModelState.IsValid)
            {
                background.User = await db.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                db.Backgrounds.Add(background);
                await db.SaveChangesAsync();
                return RedirectToAction("Backgrounds");
            }
            else
                return View("../Homebrew/BackgroundCreator/CreateBackground");

        }
        public async Task<IActionResult> AboutBackground(int? id)
        {
            if (id != null)
            {
                Background background = await db.Backgrounds.FirstOrDefaultAsync(b => b.Id == id);
                return View("../Homebrew/BackgroundCreator/AboutBackground", background);
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin, User")]
        [HttpGet]
        public async Task<IActionResult> UpdateBackground(int? id)
        {
            if (id != null)
            {
                Background background = await db.Backgrounds.FirstOrDefaultAsync(b => b.Id == id);
                if (background != null)
                {
                    return View("../Homebrew/BackgroundCreator/UpdateBackground", background);
                }
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> UpdateBackground(Background background)
        {
            if (ModelState.IsValid)
            {
                db.Backgrounds.Update(background);
                await db.SaveChangesAsync();
                return RedirectToAction("Backgrounds");
            }
            else
                return View("../Homebrew/BackgroundCreator/UpdateBackground");
        }

        [Authorize(Roles = "Admin, User")]
        [HttpGet]
        [ActionName("DeleteBackground")]
        public async Task<IActionResult> ConfirmDeleteBackground(int? id)
        {
            if (id != null)
            {
                Background background = await db.Backgrounds.FirstOrDefaultAsync(b => b.Id == id);
                if (background != null)
                {
                    return View("../Homebrew/BackgroundCreator/DeleteBackground", background);
                }
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> DeleteBackground(int? id)
        {
            if (id != null)
            {
                Background background = await db.Backgrounds.FirstOrDefaultAsync(b => b.Id == id);
                if (true)
                {
                    db.Backgrounds.Remove(background);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Backgrounds");
                }
            }
            return NotFound();
        }
    }
}
