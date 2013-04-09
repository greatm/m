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
    public class MasterProjectController : Controller
    {
        #region action
        private mDBContext db = new mDBContext();

        //
        // GET: /MasterProject/

        public ActionResult Index()
        {
            return View(db.Projects.ToList());
        }

        //
        // GET: /MasterProject/Details/5

        public ActionResult Details(int id = 0)
        {
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        //
        // GET: /MasterProject/Create

        public ActionResult Create()
        {
            //ViewBag.ProjectManagers = new SelectList(db.Employees, "ID", "FirstName");
            CreateProjectManagersList();
            return View();
        }

        //
        // POST: /MasterProject/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            CreateProjectManagersList();
            //ViewBag.ProjectManagers = new SelectList(db.Employees, "ID", "FirstName");
            return View(project);
        }


        //
        // GET: /MasterProject/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        //
        // POST: /MasterProject/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(project);
        }

        //
        // GET: /MasterProject/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        //
        // POST: /MasterProject/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        #endregion

        #region function
        private void CreateProjectManagersList()
        {
            var employees = db.Employees;
            List<object> newList = new List<object>();
            foreach (var employee in employees)
                newList.Add(new
                {
                    Id = employee.ID,
                    Name = employee.FirstName + " " + employee.LastName
                });
            this.ViewData["ProjectManagers"] = new SelectList(newList, "Id", "Name");

        }
        #endregion
    }
}