﻿using System.Web;
using System.Web.Mvc;

namespace SkillTree0706
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
