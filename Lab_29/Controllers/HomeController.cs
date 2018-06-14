﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_29.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration =20)]// 20 seconds
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
