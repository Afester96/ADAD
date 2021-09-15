using AfroDungeonAndDragons.Models;
using AfroDungeonAndDragons.Models.MainPageNews;
using AfroDungeonAndDragons.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext db;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeController(ApplicationContext context, IWebHostEnvironment hostEnvironment)
        {
            db = context;
            webHostEnvironment = hostEnvironment;
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
        }

        [Authorize(Roles = "Admin")]
        public IActionResult CreateNews()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateNews(NewsViewModel viewNews)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(viewNews);

                News news = new News
                {
                    NewsTitle = viewNews.NewsTitle,
                    ShortNewsDescription = viewNews.ShortNewsDescription,
                    NewsDescription = viewNews.NewsDescription,
                    Image = uniqueFileName,
                };

                db.News.Add(news);
                await db.SaveChangesAsync();
                return RedirectToAction("AllNews");
            }
            else
                return View();
        }

        private string UploadedFile(NewsViewModel model)
        {
            string uniqueFileName = null;

            if (model.ViewImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "news_images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ViewImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ViewImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
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
