﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace m.Controllers
{
    public class TravelController : Controller
    {
        //
        // GET: /Travel/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BookTicket()
        {
            return View();
        }
    }
}
