using AfroDungeonAndDragons.Models.CharacterCreator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class CharacterCreatorController : Controller
    {
        List<Race> races;
        public CharacterCreatorController()
        {
            races = new List<Race>
            {
                new Race {Id=1, Name="Дварф", Size=Size.Tiny, Speed=30, ShortDescription="Полные древнего величия королевства и вырезанные в " +
                "толще гор чертоги, удары кирок и молотков,раздающиеся в глубоких шахтах и пылающий кузнечный горн, верность клану и традициям и пылающая " +
                "ненависть к гоблинам и оркам — вот вещи, объединяющие всех дварфов.", Description="Описание", RacialTrait="Short and Stout", FromBook="Книга игрока"},
                new Race {Id=2, Name="Человек", Size=Size.Medium, Speed=30, ShortDescription="Человеки", Description="Описание", RacialTrait="Short and Stout", FromBook="Книга игрока"}
            };
        }
        public IActionResult Races()
        {
            return View(races);
        }
    }
}
