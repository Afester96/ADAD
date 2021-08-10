using AfroDungeonAndDragons.Models.CharacterCreator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class RacesController : Controller
    {
        List<Race> defaultRaces;
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
