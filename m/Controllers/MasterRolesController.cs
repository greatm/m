using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m.Models;
using System.Data;
using WebMatrix.WebData;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Web.Security;
using m.Migrations;

namespace m.Controllers
{
    public class MasterRolesController : Controller
    {
        private mDBContext db = new mDBContext();

        public ActionResult Index()
        {
            //var roles = (SimpleRoleProvider)Roles.Provider;
            //return View(roles);
            return View(Roles.GetAllRoles());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SimpleRoleProvider role)
        {
            if (ModelState.IsValid)
            {
                if (!Roles.RoleExists(role.Name))
                    Roles.CreateRole(role.Name);
                //db.Designations.Add(role);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(role);
        }
    }
}
