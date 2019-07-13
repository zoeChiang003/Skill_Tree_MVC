using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using SkillTree0706.Models;

namespace SkillTree0706.Controllers
{
    public class HomeController : Controller
    {
        [ChildActionOnly]
        public ActionResult SubAction()
        {
            var request = new class1
            {
                Title = "Sub123",
                Body = "Sub345"
            };
            return View(request);
        }


        public ActionResult Index()
        {
            var request = new class1
            {
                Title = "123",
                Body = "345"
            };
            return View(request);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}