using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Concrete;

namespace BlogProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminBlogList()
        {
            var result = _blogManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            _blogManager.AddBlog(blog);
            return RedirectToAction("AdminBlogList");
        }
    }
}