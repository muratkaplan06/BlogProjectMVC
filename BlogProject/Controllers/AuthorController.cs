using System.Linq;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace BlogProject.Controllers
{
    public class AuthorController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager();
        public PartialViewResult AuthorResult(int id)
        {
            var result = _blogManager.GetAll().FirstOrDefault(x=>x.BlogId==id);
            return PartialView(result);
        }

        public PartialViewResult AuthorPopularPost(int id)
        {
            var authorId=_blogManager.GetAll().Where(x=>x.BlogId==id)
                .Select(y=>y.AuthorId).FirstOrDefault();
            var result = _blogManager.GetBlogsByAuthor(authorId);
            return PartialView(result);
        }
    }
}