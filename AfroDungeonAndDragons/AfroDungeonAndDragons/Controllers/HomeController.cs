using AfroDungeonAndDragons.Models;
using AfroDungeonAndDragons.Models.MainPageNews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            var list = await db.News.ToListAsync();
            list.Reverse();
            list.Take(5);
            return View(list);
        }

        public async Task<IActionResult> AllNews(int page = 1)
        {
            int pageSize = 10;

            List<News> list = await db.News.ToListAsync();
            list.Reverse();
            var count = list.Count();
            var items = list.Skip((page - 1) * pageSize).Take(pageSize);

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                News = items
            };
            return View(viewModel);

            //List<News> list = await db.News.ToListAsync();
            //list.Reverse();
            //return View(list);
        }
        
        public IActionResult CreateNews()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNews(News news)
        {
            if (ModelState.IsValid)
            {
                db.News.Add(news);
                await db.SaveChangesAsync();
                return RedirectToAction("AllNews");
            }
            else
                return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateNews(int? id)
        {
            if (id != null)
            {
                News news = await db.News.FirstOrDefaultAsync(n => n.Id == id);
                if (news != null)
                {
                    return View(news);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateNews(News news)
        {
            if (ModelState.IsValid)
            {
                db.News.Update(news);
                await db.SaveChangesAsync();
                return RedirectToAction("AllNews");
            }
            else
                return View(news);
        }

        [HttpGet]
        [ActionName("DeleteNews")]
        public async Task<IActionResult> ConfirmDeleteNews(int? id)
        {
            if (id != null)
            {
                News news = await db.News.FirstOrDefaultAsync(n => n.Id == id);
                if (news != null)
                {
                    return View(news);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteNews(int? id)
        {
            if (id != null)
            {
                News news = await db.News.FirstOrDefaultAsync(n => n.Id == id);
                if (true)
                {
                    db.News.Remove(news);
                    await db.SaveChangesAsync();
                    return RedirectToAction("AllNews");
                }
            }
            return NotFound();
        }

        public async Task<IActionResult> AboutNews(int? id)
        {
            if (id != null)
            {
                News news = await db.News.FirstOrDefaultAsync(n => n.Id == id);
                return View(news);
            }
            return NotFound();
        }
    }
}
