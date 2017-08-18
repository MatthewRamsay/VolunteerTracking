using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VolunteerTracker.Models;
using VolunteerTracker.ViewModels;

namespace VolunteerTracker.Controllers
{
    public class VolunteerViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: VolunteerViewModels
        public ActionResult Index()
        {
            return View(db.VolunteerViewModels.ToList());
        }

        // GET: VolunteerViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerViewModel volunteerViewModel = db.VolunteerViewModels.Find(id);
            if (volunteerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(volunteerViewModel);
        }

        // GET: VolunteerViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VolunteerViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,UserName,Password,DayAvailable,CenterPreferred,EducationLevel,Skill,CurrentLicense,Phone,Email,HasDriversLicense,HasSsCard,Status")] VolunteerViewModel volunteerViewModel)
        {
            if (ModelState.IsValid)
            {
                db.VolunteerViewModels.Add(volunteerViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volunteerViewModel);
        }

        // GET: VolunteerViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerViewModel volunteerViewModel = db.VolunteerViewModels.Find(id);
            if (volunteerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(volunteerViewModel);
        }

        // POST: VolunteerViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,UserName,Password,DayAvailable,CenterPreferred,EducationLevel,Skill,CurrentLicense,Phone,Email,HasDriversLicense,HasSsCard,Status")] VolunteerViewModel volunteerViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteerViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteerViewModel);
        }

        // GET: VolunteerViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerViewModel volunteerViewModel = db.VolunteerViewModels.Find(id);
            if (volunteerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(volunteerViewModel);
        }

        // POST: VolunteerViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VolunteerViewModel volunteerViewModel = db.VolunteerViewModels.Find(id);
            db.VolunteerViewModels.Remove(volunteerViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
