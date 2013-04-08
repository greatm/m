﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m.Models;

namespace m.Controllers
{
    public class MasterUsersController : Controller
    {
        private mDBContext db = new mDBContext();
        //private UsersContext db = new UsersContext();

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
            //return View(db.UserProfiles.ToList());
        }

    }
}
