using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using blog.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.IO;
using System.Net.Http.Headers;
//using ClientNotifications;
//using static ClientNotifications.Helpers.NotificationHelper;

namespace blog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {

        private ApplicationDbContext _context;
      //  private IClientNotification _client;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(ApplicationDbContext context,
       
       
                                UserManager<ApplicationUser> userManager)
        {
            _context = context;
          

            _userManager = userManager;
        }

        [AllowAnonymous]
        
        public IActionResult Index(string search)
        {
            var search1 = _context.Posts.OrderByDescending(x=>x.Date).Where(x => x.Heading.Contains(search) || x.Description.Contains(search) || search == null).ToList();
            return View(search1);


            

        }
        

        public IActionResult MyPosts()
        {
            var userId = _userManager.GetUserId(HttpContext.User);

            var myposts = _context.Posts.OrderByDescending(x => x.Date).Where(x => x.UserId.Equals(userId)).ToList();

            ViewBag.PlusPoints = myposts.Sum(x => x.Point);

            return View(myposts);
        }


        [HttpPost]
        // public IActionResult AddData(Post x)
        // {
        //     x.UserId = _userManager.GetUserId(HttpContext.User);
        //     x.UserName = _userManager.GetUserName(HttpContext.User);

        //     // x.UserId = userId;
        //     _context.Posts.Add(x);
        //     _context.SaveChanges();
        //     //_client.AddToastNotification("Posted",NotificationType.success, null);
        //     return RedirectToAction("MyPosts");
        // }

        public async Task<IActionResult> NewPost([Bind("Id,UserId,Category,Heading,Description,UserName,Points,Comments,CommentsId,Date")]Post post)
        {

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {

                    var file = Image;
                    var uploads = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    // var uploads = Path.Combine(_environment.WebRootPath, "uploads\\img\\employees");

                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse
                            (file.ContentDisposition).FileName.Trim('"');

                        System.Console.WriteLine(fileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            post.PhotoName = file.FileName;
                        }


                    }
                }
            }


            post.UserName = _userManager.GetUserName(HttpContext.User);
            post.UserId = _userManager.GetUserId(HttpContext.User);
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
           // _client.AddToastNotification("Posted",NotificationType.success, null);

            return RedirectToAction("Index", "Post");








        }
        public IActionResult New()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult SeeMore1(int id, string cat)
        {
            var post = _context.Posts.SingleOrDefault(y => y.Id == id);

            var comments = _context.Comments.Where(x => x.PostId == id).ToList();
            var relatedposts = _context.Posts.Where(x => x.Category.Equals(cat)).Take(2).ToList();
            ViewBag.Comments = comments;
            ViewBag.RelatedPosts = relatedposts;
            return View(post);
        }

        [AllowAnonymous]
        public IActionResult SeeMore(int id)
        {
            var post = _context.Posts.FirstOrDefault(y => y.Id == id);

            var comments = _context.Comments.Where(x => x.PostId == id).ToList();
            ViewBag.Comments = comments;

            // var replies = _context.Repliestbl.Where(x=>x.CommentId ==id).ToList();
            // ViewBag.Replies = replies;

            return View(post);
        }
        public IActionResult Edit(int id)
        {
            var Id = _userManager.GetUserId(HttpContext.User);
            var post = _context.Posts.FirstOrDefault(x => x.Id == id);

            if (!post.UserId.Equals(Id))
                return RedirectToAction("AccessDenied", "Home");

            return View(post);
        }

        public IActionResult Update(Post u)
        {
            u.UserId = _userManager.GetUserId(HttpContext.User);
            u.UserName = _userManager.GetUserName(HttpContext.User);

            _context.Posts.Update(u);
            _context.SaveChanges();
            return RedirectToAction("MyPosts");
        }
        public IActionResult Delete(int id)
        {
            var Id = _userManager.GetUserId(HttpContext.User);
            var st = _context.Posts.FirstOrDefault(x => x.Id == id);
            
            if (!st.UserId.Equals(Id))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            else
            {
                _context.Posts.Remove(st);
                _context.SaveChanges();
                
                return RedirectToAction("MyPosts");
            }
        }


        // Comments
        public IActionResult AddComment(int postId, string commentText, string Photo, string cat)
        {


            var comment = new Comment();
            comment.PhotoName = Photo;
            comment.PostId = postId;
            comment.Text = commentText;
            comment.Username = _userManager.GetUserName(HttpContext.User);
            comment.UserId = _userManager.GetUserId(HttpContext.User);



            _context.Comments.Add(comment);

            _context.SaveChanges();

            return RedirectToAction(nameof(SeeMore1), new { id = postId });
        }




        public IActionResult DeleteComment(int id)
        {
            //  var comment = new Comment();
            // comment.PostId = postId;

            var p = _userManager.GetUserId(HttpContext.User);

            var del = _context.Comments.FirstOrDefault(x => x.Id == id);
            //   var comment = _context.Comments.FirstOrDefault(x=>x.Id==id);

            int pId = del.PostId;
            if (!del.UserId.Equals(p))
                return RedirectToAction("AccessDenied", "Home");

            _context.Comments.Remove(del);
            _context.SaveChanges();
            return RedirectToAction(nameof(SeeMore1), new { id = pId });


        }
        public IActionResult PointUp(int id)
        {
            var post = _context.Posts.FirstOrDefault(x => x.Id == id);
            post.Point = post.Point + 1;
            _context.Posts.Update(post);
            _context.SaveChanges();
            return RedirectToAction(nameof(SeeMore1), new { id = id });
        }
        public IActionResult PointDown(int id)
        {
            var post = _context.Posts.FirstOrDefault(x => x.Id == id);
            if (post.Point > 0)
            {
                post.Point = post.Point - 1;
                _context.Posts.Update(post);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(SeeMore), new { id = id });
        }
        public IActionResult ReplyComment(string replyMessage, int commentId, int postId)
        {
            var reply = new Reply();
            reply.CommentId = commentId;
            reply.Message = replyMessage;
            reply.Username = _userManager.GetUserName(HttpContext.User);

            _context.Replies.Add(reply);

            _context.SaveChanges();

            // var del = _context.Comments.FirstOrDefault(x => x.Id == id);
            //  int pId = del.PostId;

            // return RedirectToAction(nameof(SeeMore), new { id = pId });
            return RedirectToAction(nameof(SeeMore), new { id = postId });

        }
        public IActionResult footer()

        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Category(string category)
        {
            var profile = _context.Posts.Where(x => x.Category.Equals(category)).ToList();

            ViewBag.Ca = category;
            return View(profile);

        }




    }
}
