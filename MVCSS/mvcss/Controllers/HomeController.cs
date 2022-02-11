using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace MVCSS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult Education()
        {
            ViewBag.Message = "Education";

            return View();
        }

        public ActionResult Experience()
        {
            ViewBag.Message = "Experience";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string contact_name, string contact_email, string contact_phone, string contact_message)
        {
            contact_name.Trim();
            if (!contact_name.Contains(" "))
            {
                ModelState.AddModelError("name error", "You must include first and last name.");
            }
            Regex phonechecker = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (!String.IsNullOrWhiteSpace(contact_phone))
            {
                if (!phonechecker.IsMatch(contact_phone))
                {
                    ModelState.AddModelError("phone error", "Your phone number must contain 10 digits.");
                }
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("ContactAcknowledgement");
            }
            ViewBag.Message = "Contact";
            return View();
        }
        public ActionResult ContactAcknowledgement()
        {
            ViewBag.Message = "Contact Acknowledgement";
            return View();
        }
    }
}