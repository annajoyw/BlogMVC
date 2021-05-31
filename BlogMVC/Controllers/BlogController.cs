using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMVC.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{year:int}/{month:int}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            ViewBag.Title = "My Blog Post";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Author = "Jess Chadwick";
            ViewBag.Body = "This is a great blog post";
;
            return View();
        }
    }
}
