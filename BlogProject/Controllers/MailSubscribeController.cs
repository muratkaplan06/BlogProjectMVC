using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogProject.Controllers
{
    public class MailSubscribeController : Controller
    {
        private readonly Repository<SubscribeMail> _repository = new Repository<SubscribeMail>();

        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail subscribeMail)
        {
            if (!ModelState.IsValid)
            {
                return PartialView();
            }
            SubsribeMailManager sm = new SubsribeMailManager();

            if (IsEmailExists(subscribeMail.EmailAddress))
            {
                ViewBag.ErrorMessage = "Bu e-posta adresi zaten kayıtlı.";
                return PartialView();
            }
            if (!string.IsNullOrEmpty(subscribeMail.EmailAddress) )
            {
                sm.Add(subscribeMail);
                ModelState.Clear();
                ViewBag.SuccessMessage = "Abone oldunuz!";
            }

           
            return PartialView();
        }
        public bool IsEmailExists(string email)
        {
            
            return _repository.List().Any(x => x.EmailAddress == email);
        }
    }
}