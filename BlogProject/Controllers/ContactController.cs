using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactManager _contactManager = new ContactManager();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            _contactManager.InsertContact(contact);
            ViewBag.SuccessMessage = "Mesajınız iletildi!";
            return View(contact);
        }
    }
}