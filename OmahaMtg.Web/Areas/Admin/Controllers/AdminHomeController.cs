﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OmahaMtg.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminHomeController : Controller
    {
        // GET: Admin/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}