using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWeb.DAL;
using ProniaWeb.Models;
using ProniaWeb.Utilies.File;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaWeb.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class Slide : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public Slide(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Slider.ToListAsync();
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Slider.Any(x => x.Title.ToLower().Trim() == slider.Title.ToLower().Trim());
            if (isExist) return View();
            if(slider.Photo.CheckSize(200))
            {
                ModelState.AddModelError("Photo", "200kb boyuk image yuklene bilmez");
                return View();
            }
            if(slider.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "Yalniz image yuklenmelidir");
                return View();
            }
            slider.Image = await slider.Photo.SaveFileAsync(Path.Combine(_env.WebRootPath, "assets", "images", "slider", "inner-img"));
            await _context.Slider.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Slider slider = _context.Slider.Find(id);
            if (slider == null) return NotFound();
            FileExtension.DeleteSlideItem(Path.Combine(_env.WebRootPath, "assets", "images", "slider", "inner-img", slider.Image));
            _context.Slider.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            Slider slider = _context.Slider.Find(id);
            if (slider == null) return NotFound();

            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,Slider slider)
        {
            if(slider.Id != id) return BadRequest();
            Slider sliderItem = _context.Slider.Find(id);
            sliderItem.Title = slider.Title;
            sliderItem.Description = slider.Description;
            sliderItem.DiscountPercent = slider.DiscountPercent;
            sliderItem.Image = slider.Image;
            if (sliderItem == null) return NotFound();
            if (sliderItem.Photo.CheckSize(200))
            {
                ModelState.AddModelError("Photo", "200kb boyuk image yuklene bilmez");
                return View();
            }
            if (sliderItem.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "Yalniz image yuklenmelidir");
                return View();
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
