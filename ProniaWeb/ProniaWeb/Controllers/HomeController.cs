using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProniaWeb.DAL;
using ProniaWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProniaWeb.HomeVM;

namespace ProniaWeb.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get;}
        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Slider.ToListAsync();
            return View(slider);
        }
    }
}
