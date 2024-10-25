using Microsoft.AspNetCore.Mvc;
using PostoSocial.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace PostoSocial.Controllers
{
    public class HomeController : Controller
    {
        private PostoContext ctx;

        public HomeController(PostoContext context)
        {
            ctx = context;
        }

        public IActionResult Index()
        {
            ViewBag.ReccomendedForums = ctx.Forums.ToList();
            var Posts = ctx.Posts.Include(p => p.User).Include(p => p.Forum).ToList();
            return View(Posts);
        }
    }
}
