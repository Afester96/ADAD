using AfroDungeonAndDragons.Models;
using AfroDungeonAndDragons.Models.CharacterCreator;
using AfroDungeonAndDragons.Models.DefaultInformation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class RacesController : Controller
    {
        private ApplicationContext db;
        public RacesController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> AllRaces()
        {
            List<DefaultRace> dr = await db.DefaultRaces.ToListAsync();
            return View(dr.OrderBy(r => r.Name));
        }
        public async Task<IActionResult> AboutRace(int? id)
        {
            if (id != null)
            {
                DefaultRace race = await db.DefaultRaces.FirstOrDefaultAsync(r => r.Id == id);
                return View(race);
            }
            return NotFound();
        }
    }
}
