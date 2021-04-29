using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;

namespace LTQL.Controllers
{
    public class PHIEUXUATsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: PHIEUXUATs
        public ActionResult Index()
        {
            return View(db.PHIEUXUATs.ToList());
        }

        // GET: PHIEUXUATs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUXUAT pHIEUXUAT = db.PHIEUXUATs.Find(id);
            if (pHIEUXUAT == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUXUAT);
        }

        // GET: PHIEUXUATs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PHIEUXUATs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPX,MaMH,Ngayxuat,Nhanvien")] PHIEUXUAT pHIEUXUAT)
        {
            if (ModelState.IsValid)
            {
                db.PHIEUXUATs.Add(pHIEUXUAT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pHIEUXUAT);
        }

        // GET: PHIEUXUATs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUXUAT pHIEUXUAT = db.PHIEUXUATs.Find(id);
            if (pHIEUXUAT == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUXUAT);
        }

        // POST: PHIEUXUATs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPX,MaMH,Ngayxuat,Nhanvien")] PHIEUXUAT pHIEUXUAT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEUXUAT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHIEUXUAT);
        }

        // GET: PHIEUXUATs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUXUAT pHIEUXUAT = db.PHIEUXUATs.Find(id);
            if (pHIEUXUAT == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUXUAT);
        }

        // POST: PHIEUXUATs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PHIEUXUAT pHIEUXUAT = db.PHIEUXUATs.Find(id);
            db.PHIEUXUATs.Remove(pHIEUXUAT);
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
