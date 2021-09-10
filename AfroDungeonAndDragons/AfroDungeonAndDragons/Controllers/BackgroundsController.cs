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
    public class BackgroundsController : Controller
    {
        private ApplicationContext db;
        public BackgroundsController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> AllBackgrounds()
        {
            List<DefaultBackground> dbc = await db.DefaultBackgrounds.ToListAsync();
            return View(dbc.OrderBy(b => b.Name));
        }

        public async Task<IActionResult> AboutBackground(int? id)
        {
            if (id != null)
            {
                DefaultBackground background = await db.DefaultBackgrounds.FirstOrDefaultAsync(b => b.Id == id);
                return View(background);
            }
            return NotFound();
        }
    }
}
