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
    public class ClassCreatorController : Controller
    {
        private ApplicationContext db;
        public ClassCreatorController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Classes()
        {
            if (User.IsInRole("User"))
            {
                if (db.Backgrounds.Where(n => n.User.Login == User.Identity.Name).Count() >= 0)
                {
                    return View("../Homebrew/ClassCreator/Classes", await db.Classes.Where(n => n.User.Login == User.Identity.Name).ToListAsync());
                }
                else
                    return RedirectToAction("BestClasses");
            }
            if (User.IsInRole("Admin"))
            {
                return View("../Homebrew/ClassCreator/Classes", await db.Classes.ToListAsync());
            }
            return RedirectToAction("BestClasses");
        }

        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> BestClasses()
        {
            return View("../Homebrew/ClassCreator/Classes", await db.Backgrounds.Where(r => r.Best == true).ToListAsync());
        }

        [Authorize(Roles = "Admin, User")]
        public IActionResult CreateClass()
        {
            return View("../Homebrew/ClassCreator/CreateClass");
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> CreateClass(Class classCreator)
        {
            if (ModelState.IsValid)
            {
                classCreator.User = await db.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                db.Classes.Add(classCreator);
                await db.SaveChangesAsync();
                return RedirectToAction("Classes");
            }
            else
                return View("../Homebrew/ClassCreator/CreateClass");
        }

        public async Task<IActionResult> AboutClass(int? id)
        {
            if (id != null)
            {
                Class classCreator = await db.Classes.FirstOrDefaultAsync(cl => cl.Id == id);
                return View("../Homebrew/ClassCreator/AboutClass", classCreator);
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin, User")]
        [HttpGet]
        public async Task<IActionResult> UpdateClass(int? id)
        {
            if (id != null)
            {
                Class classCreator = await db.Classes.FirstOrDefaultAsync(cl => cl.Id == id);
                if (classCreator != null)
                {
                    return View("../Homebrew/ClassCreator/UpdateClass", classCreator);
                }
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> UpdateClass(Class classCreator)
        {
            if (ModelState.IsValid)
            {
                db.Classes.Update(classCreator);
                await db.SaveChangesAsync();
                return RedirectToAction("Classes");
            }
            else
                return View("../Homebrew/ClassCreator/UpdateClass");
        }

        [Authorize(Roles = "Admin, User")]
        [HttpGet]
        [ActionName("DeleteClass")]
        public async Task<IActionResult> ConfirmDeleteClass(int? id)
        {
            if (id != null)
            {
                Class classCreator = await db.Classes.FirstOrDefaultAsync(cl => cl.Id == id);
                if (classCreator != null)
                {
                    return View("../Homebrew/ClassCreator/DeleteClass", classCreator);
                }
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public async Task<IActionResult> DeleteClass(int? id)
        {
            if (id != null)
            {
                Class classCreator = await db.Classes.FirstOrDefaultAsync(cl => cl.Id == id);
                if (true)
                {
                    db.Classes.Remove(classCreator);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Classes");
                }
            }
            return NotFound();
        }
    }
}
