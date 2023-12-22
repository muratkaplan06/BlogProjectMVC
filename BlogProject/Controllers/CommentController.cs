using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentManager _commentManager = new CommentManager();
        public PartialViewResult CommentList(int id)
        {
            var result = _commentManager.GetCommentsById(id);
            ViewBag.id = id;
            return PartialView(result);
        }
        [HttpGet]
        public ActionResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public ActionResult LeaveComment(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _commentManager.CommentAdd(comment);
            ModelState.Clear();
            return RedirectToAction("CommentConfirmation");
            return View();
        }
        public ActionResult CommentConfirmation()
        {
            return View();
        }

    }
}