using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using blog.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using System.Net.Http.Headers;

namespace blog.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProfileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
       


        public IActionResult New()
        {
            return View();
        }
        // public IActionResult Create(Profile P)
        // {
        //     try
        //     {
        //         P.Email = _userManager.GetUserName(HttpContext.User);
        //         P.ApplicationUserId = _userManager.GetUserId(HttpContext.User);
        //         _context.Profiles.Add(P);
        //         _context.SaveChanges(); 
        //     }
        //     catch (Exception)
        //     {
        //         return Content("Profile already exists. Could not create ...");
        //     }

        //     return RedirectToAction("Index","Profile");
        // }
         public async Task<IActionResult> Create([Bind("Id,Email,NickName,Gender,DOB,Biography,PostType,Address,Phone,Interest")]Profile profile)
        {

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {

                    var file = Image;
                    var uploads = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/profiles");
                    // var uploads = Path.Combine(_environment.WebRootPath, "uploads\\img\\employees");

                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse
                            (file.ContentDisposition).FileName.Trim('"');

                        System.Console.WriteLine(fileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            profile.PhotoName = file.FileName;
                        }


                    }
                }
            }
          

           profile.Email = _userManager.GetUserName(HttpContext.User);
           profile.ApplicationUserId = _userManager.GetUserId(HttpContext.User);
            _context.Profiles.Add(profile);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Post");
}

        public IActionResult Edit(int id)
        {
            var u = _context.Profiles.FirstOrDefault(x => x.Id == id);
            return View(u);
        }
        public IActionResult Update(Profile P)
        {
            P.Email = _userManager.GetUserName(HttpContext.User);
            // P.ApplicationUserId= _userManager.GetUserId(HttpContext.User);
            _context.Profiles.Update(P);
            _context.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
[AllowAnonymous]
        public IActionResult AuthorProfile(string username)
        {

            //var s = _context.Posts.FirstOrDefault(x=>x.UserName.Equals(username));
            //  var check = _context.Profiles.Where(x=>x.Email.Equals(s)).ToList();
            //      return View (check);
            //  }  
            var profile = _context.Profiles.FirstOrDefault(x => x.Email.Equals(username));
            return View(profile);
        }

         public IActionResult Index()
        {
            var p = _userManager.GetUserName(HttpContext.User);
            //var s = _context.Profiles.Where(x => x.Email.Equals(p)).ToList();
            var s = _context.Profiles.FirstOrDefault(x => x.Email.Equals(p));

            return View(s);

        }
        public IActionResult hh()
        {
            return View();
        }
        public IActionResult UpdatePhoto(int id)
        {
          var up= _context.Profiles.FirstOrDefault(x=>x.Id == id);
           up.PhotoName = "hhhh.jpg";
           _context.SaveChanges();
           return RedirectToAction ("Index","Profile");

        }

    }
}