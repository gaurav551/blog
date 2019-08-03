using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using blog.Data;
using Microsoft.AspNetCore.Authorization;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PageNotFound(){
            return View();
        }
        
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Nav()
        {
            return View();
        }
       
    }
}
