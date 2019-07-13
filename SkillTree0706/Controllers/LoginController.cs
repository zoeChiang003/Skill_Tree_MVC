using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree0706.Models;

namespace SkillTree0706.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        // GET: Login
        [HttpPost]
        public ActionResult Login(LoginViewModel pageData)
        {
            if (pageData.Account == "skill" &&
                pageData.Password == "tree")
            {
                pageData.Message = $"您使用{pageData.Account}登入成功。";
            }
            return View(pageData);
        }
    }
}