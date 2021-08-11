using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class CharacterCreatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
