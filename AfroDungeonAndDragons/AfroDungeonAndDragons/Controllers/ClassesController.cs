using AfroDungeonAndDragons.Models;
using AfroDungeonAndDragons.Models.DefaultInformation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class ClassesController : Controller
    {
        private ApplicationContext db;
        public ClassesController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> AllClasses()
        {
            return View(await db.DefaultClasses.ToListAsync());
        }
        public async Task<IActionResult> AboutClass(int? id)
        {
            if (id != null)
            {
                DefaultClass customClass = await db.DefaultClasses.FirstOrDefaultAsync(cl => cl.Id == id);
                return View(customClass);
            }
            return NotFound();
        }
    }
}
