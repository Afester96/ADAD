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
    public class BackgroundCreatorController : Controller
    {
        private ApplicationContext db;
        public BackgroundCreatorController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Backgrounds()
        {
            return View("../Homebrew/BackgroundCreator/Backgrounds", await db.Backgrounds.ToListAsync());
        }
        public IActionResult CreateBackground()
        {
            return View("../Homebrew/BackgroundCreator/CreateBackground");
        }
        [HttpPost]
        public async Task<IActionResult> CreateBackground(Background background)
        {
            db.Backgrounds.Add(background);
            await db.SaveChangesAsync();
            return RedirectToAction("Backgrounds");
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
        [HttpPost]
        public async Task<IActionResult> UpdateBackground(Background background)
        {
            db.Backgrounds.Update(background);
            await db.SaveChangesAsync();
            return RedirectToAction("Backgrounds");
        }
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
