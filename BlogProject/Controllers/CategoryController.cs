using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            var result = _categoryManager.GetAll();
            return View(result);
        }

        public PartialViewResult BlogDetailsCategoryList()
        {
            var result = _categoryManager.GetAll();
            return PartialView(result);
        }
    }
}