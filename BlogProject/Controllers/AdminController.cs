using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Concrete;
using System.Web.Mvc;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager();
        private readonly CategoryManager _categoryManager = new CategoryManager();

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
            Context context = new Context();
            var categoryList = (from x in context.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();

            ViewBag.categoryList = categoryList;
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _blogManager.AddBlog(blog);
                return RedirectToAction("AdminBlogList");
            }
            Context context = new Context();
            var categoryList = (from x in context.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();

            ViewBag.categoryList = categoryList;

            
            return View(blog);

        }
    }
}