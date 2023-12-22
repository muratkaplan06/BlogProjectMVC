using System.Linq;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using PagedList;

namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager();
        private readonly CategoryManager _categoryManager = new CategoryManager();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = _blogManager.GetAll().ToPagedList(page, 6);
            return PartialView(blogList);
        }

        public PartialViewResult FeaturedPost()
        {
            var postTitle1 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage1 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate1 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 1).Select(y => y.CreatedTime).FirstOrDefault();
            ViewBag.postTitle1 = postTitle1;
            ViewBag.postImage1 = postImage1;
            ViewBag.blogDate1 = blogDate1;

            var postTitle2 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage2 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate2 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 2).Select(y => y.CreatedTime).FirstOrDefault();
            ViewBag.postTitle2 = postTitle2;
            ViewBag.postImage2 = postImage2;
            ViewBag.blogDate2 = blogDate2;

            var postTitle3 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage3 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate3 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 3).Select(y => y.CreatedTime).FirstOrDefault();
            ViewBag.postTitle3 = postTitle3;
            ViewBag.postImage3 = postImage3;
            ViewBag.blogDate3 = blogDate3;

            var postTitle4 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage4 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate4 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 4).Select(y => y.CreatedTime).FirstOrDefault();
            ViewBag.postTitle4 = postTitle4;
            ViewBag.postImage4 = postImage4;
            ViewBag.blogDate4 = blogDate4;

            var postTitle5 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage5 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 5).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate5 = _blogManager.GetAll().OrderByDescending(z => z.BlogId)
                .Where(x => x.CategoryId == 5).Select(y => y.CreatedTime).FirstOrDefault();
            ViewBag.postTitle5 = postTitle5;
            ViewBag.postImage5 = postImage5;
            ViewBag.blogDate5 = blogDate5;

            return PartialView();
        }
        public PartialViewResult OtherFeaturedPost()
        {
            var postTitle1 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage1 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate1 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 1).Select(y => y.CreatedTime).FirstOrDefault();
            var categoryName1 = _categoryManager.Get(1).CategoryName;
            ViewBag.postTitle1 = postTitle1;
            ViewBag.postImage1 = postImage1;
            ViewBag.blogDate1 = blogDate1;
            ViewBag.categoryName1 = categoryName1;

            var postTitle2 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage2 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate2 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 2).Select(y => y.CreatedTime).FirstOrDefault();
            var categoryName2 = _categoryManager.Get(2).CategoryName;
            ViewBag.postTitle2 = postTitle2;
            ViewBag.postImage2 = postImage2;
            ViewBag.blogDate2 = blogDate2;
            ViewBag.categoryName2 = categoryName2;

            var postTitle3 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage3 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate3 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 3).Select(y => y.CreatedTime).FirstOrDefault();
            var categoryName3 = _categoryManager.Get(3).CategoryName;
            ViewBag.postTitle3 = postTitle3;
            ViewBag.postImage3 = postImage3;
            ViewBag.blogDate3 = blogDate3;
            ViewBag.categoryName3 = categoryName3;

            var postTitle4 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage4 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogDate4 = _blogManager.GetAll().OrderBy(z => z.BlogId)
                .Where(x => x.CategoryId == 4).Select(y => y.CreatedTime).FirstOrDefault();
            var categoryName4 = _categoryManager.Get(4).CategoryName;
            ViewBag.postTitle4 = postTitle4;
            ViewBag.postImage4 = postImage4;
            ViewBag.blogDate4 = blogDate4;
            ViewBag.categoryName4 = categoryName4;

            return PartialView();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }

        public PartialViewResult BlogCover(int? id)
        {
            var result = _blogManager.GetAll().FirstOrDefault(x => x.BlogId == id);
            return PartialView(result);
        }

        public PartialViewResult BlogReadAll(int? id)
        {
            if (id != null)
            {
                var result = _blogManager.GetAll().FirstOrDefault(x => x.BlogId == id);
                return PartialView(result);
            }

            return PartialView();
        }

        public ActionResult BlogByCategory(int id, int page = 1)
        {
            var result = _blogManager.GetBlogsByCategory(id).ToPagedList(page, 6);

            var categoryName = result
                .Select(y => y.Category.CategoryName).FirstOrDefault();
            ViewBag.categoryName = categoryName;
            var categoryDescription = result
                .Select(y => y.Category.CategoryDescription).FirstOrDefault();
            ViewBag.categoryDescription = categoryDescription;

            return View(result);
        }

    }
}