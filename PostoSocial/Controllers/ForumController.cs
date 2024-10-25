using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostoSocial.Models;

namespace PostoSocial.Controllers
{
    public class ForumController : Controller
    {
        private PostoContext ctx;

        public ForumController(PostoContext context)
        {
            ctx = context;
        }
        public IActionResult Home(string forumName)
        {
            Forum forum = ctx.Forums.Where(f => f.ForumName == forumName).FirstOrDefault();
            ViewBag.Posts = ctx.Posts.Where(p => p.ForumId == forum.ForumId).Include(p => p.Forum).Include(p => p.User).ToList();
            return View(forum);
        }
    }
}
