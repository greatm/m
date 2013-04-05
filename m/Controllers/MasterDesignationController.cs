using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m.Models;

namespace m.Controllers
{
    public class MasterDesignationController : Controller
    {
        private mDBContext db = new mDBContext();

        //
        // GET: /MasterDesignation/

        public ActionResult Index(string searchString)
        {
            //var desigs = from m in db.Designations select m;
            var desigs = db.Designations.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                desigs = desigs.Where(s => s.Name.Contains(searchString)).ToList();
            }

            return View(desigs);
            //return View(db.Designations.ToList());
        }

        //
        // GET: /MasterDesignation/Details/5

        public ActionResult Details(int id = 0)
        {
            Designation designation = db.Designations.Find(id);
            if (designation == null)
            {
                return HttpNotFound();
            }
            return View(designation);
        }

        //
        // GET: /MasterDesignation/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MasterDesignation/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Designation designation)
        {
            if (ModelState.IsValid)
            {
                db.Designations.Add(designation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(designation);
        }

        //
        // GET: /MasterDesignation/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Designation designation = db.Designations.Find(id);
            if (designation == null)
            {
                return HttpNotFound();
            }
            return View(designation);
        }

        //
        // POST: /MasterDesignation/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Designation designation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(designation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(designation);
        }

        //
        // GET: /MasterDesignation/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Designation designation = db.Designations.Find(id);
            if (designation == null)
            {
                return HttpNotFound();
            }
            return View(designation);
        }

        //
        // POST: /MasterDesignation/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Designation designation = db.Designations.Find(id);
            db.Designations.Remove(designation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}