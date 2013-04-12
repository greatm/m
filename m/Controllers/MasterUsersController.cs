using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m.Models;
using System.Data;
using WebMatrix.WebData;

namespace m.Controllers
{
    public class MasterUsersController : Controller
    {
        private mDBContext db = new mDBContext();

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult Create()
        {
            this.ViewData["Designations"] = new SelectList(db.Designations.ToList(), "ID", "Name");
            this.ViewData["Grades"] = new SelectList(db.Grades.ToList(), "ID", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                WebSecurity.CreateUserAndAccount(model.UserName, model.Password, new
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Mobile = model.Mobile,
                    eMail = model.eMail,
                    DesignationID = model.DesignationID,
                    Father = model.Father,
                    Mother = model.Mother
                });
                WebSecurity.Login(model.UserName, model.Password);
                return RedirectToAction("Index");
            }

            this.ViewData["Designations"] = new SelectList(db.Designations.ToList(), "ID", "Name");
            return View(model);
        }

        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            this.ViewData["Grades"] = new SelectList(db.Grades.ToList(), "ID", "Name");
            return View(new RegisterModel(employee));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            this.ViewData["Grades"] = new SelectList(db.Grades.ToList(), "ID", "Name");
            return View(model);
        }
        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee album = db.Employees.Find(id);
            db.Employees.Remove(album);
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
