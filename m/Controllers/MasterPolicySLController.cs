using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m.Models;

namespace m.Controllers
{
    public class MasterPolicySLController : Controller
    {
        private mDBContext db = new mDBContext();
        //
        // GET: /MasterPolicySL/

        public ActionResult Index()
        {
            return View(db.Leaves.ToList());
        }

    }
}
