using System.Web.Mvc;

namespace SkillTree0706.Areas.LoginInfo
{
    public class LoginInfoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LoginInfo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LoginInfo_default",
                "LoginInfo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}