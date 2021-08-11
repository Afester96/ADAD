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
    public class ClassCreatorController : Controller
    {
        private ApplicationContext db;
        public ClassCreatorController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Classes()
        {
            return View("../Homebrew/ClassCreator/Classes", await db.Classes.ToListAsync());
        }
        public IActionResult CreateBackground()
        {
            return View("../Homebrew/ClassCreator/CreateClass");
        }
        [HttpPost]
        public async Task<IActionResult> CreateClass(Class classCreator)
        {
            db.Classes.Add(classCreator);
            await db.SaveChangesAsync();
            return RedirectToAction("Classes");
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
        [HttpPost]
        public async Task<IActionResult> UpdateClass(Class classCreator)
        {
            db.Classes.Update(classCreator);
            await db.SaveChangesAsync();
            return RedirectToAction("Classes");
        }
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
