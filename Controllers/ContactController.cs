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
    public class ContactController : Controller
    {
        private ApplicationDbContext _context;
        public ContactController (ApplicationDbContext context)
        {
            _context = context;
        }
[Authorize(Roles="Gaurav")]
          public IActionResult Index()
          {
              var C = _context.Contacts.ToList();
          return View (C);
          }
          public IActionResult New()
        {
            return View();
        }
        public IActionResult AddContact(Contact c)
        {
             _context.Contacts.Add(c);
            _context.SaveChanges();
            return Content("Thanks You FOr ypour message");
           // return RedirectToAction ("Index", "Post");
        }
    }
}