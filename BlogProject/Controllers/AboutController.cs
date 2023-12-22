using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace BlogProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AboutManager _aboutManager = new AboutManager();
        private readonly AuthorManager _authorManager = new AuthorManager();
        public ActionResult Index()
        {
            var result = _aboutManager.GetAll();
            return View(result);
        }

        public PartialViewResult Footer()
        {
            var result = _aboutManager.GetAll();
            return PartialView(result);
        }

        public PartialViewResult MeetTheTeam()
        {
            var result = _authorManager.GetAll();
            return PartialView(result);
        }
    }
}