﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2() { return View(); }
    }
}