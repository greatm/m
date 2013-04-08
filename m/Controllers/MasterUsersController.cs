using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m.Models;

namespace m.Controllers
{
    public class MasterUsersController : Controller
    {
        private UsersContext db = new UsersContext();
        //
        // GET: /MasterUsers/

        public ActionResult Index()
        {
            return View(db.UserProfiles.ToList());
            //return View();
        }

    }
}
