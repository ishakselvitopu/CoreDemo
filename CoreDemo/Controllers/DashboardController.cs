using DataAcessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        Context context = new Context();
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.blogCount = context.Blogs.Count().ToString();
            ViewBag.youBlogCount = context.Blogs.Where(x => x.WriterID == 1).Count();
            ViewBag.categoriCount = context.Categories.Count();
            return View();
        }
    }
}
