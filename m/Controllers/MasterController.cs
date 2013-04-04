using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace m.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Administrator")]
    public class MasterController : Controller
    {
        //
        // GET: /Master/

        public ActionResult Index()
        {
            return View();
        }

    }
}
