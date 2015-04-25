﻿using System.Web.Mvc;

namespace OmahaMtg.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name : "Admin_default",
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { action = "Index", controller = "AdminHome", id = UrlParameter.Optional },
                constraints: new { isinrole= new AdminRouteConstaint()},
                namespaces: new[] { "OmahaMtg.Web.Areas.Admin.Controllers" }
                );
        }
    }
}