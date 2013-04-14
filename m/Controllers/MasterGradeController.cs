using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m.Models;

namespace m.Controllers
{
    public class MasterGradeController : Controller
    {
        private mDBContext db = new mDBContext();

        public ActionResult Index()
        {
            return View(db.Grades.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Grade grade)
        {
            if (ModelState.IsValid)
            {
                db.Grades.Add(grade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grade);
        }

    }
}
