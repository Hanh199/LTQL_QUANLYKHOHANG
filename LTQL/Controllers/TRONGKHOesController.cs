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
    public class TRONGKHOesController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TRONGKHOes
        public ActionResult Index()
        {
            return View(db.TRONGKHOs.ToList());
        }

        // GET: TRONGKHOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRONGKHO tRONGKHO = db.TRONGKHOs.Find(id);
            if (tRONGKHO == null)
            {
                return HttpNotFound();
            }
            return View(tRONGKHO);
        }

        // GET: TRONGKHOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRONGKHOes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STT,Tenkho,TenMH,Soluong,DVT,Dongia")] TRONGKHO tRONGKHO)
        {
            if (ModelState.IsValid)
            {
                db.TRONGKHOs.Add(tRONGKHO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRONGKHO);
        }

        // GET: TRONGKHOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRONGKHO tRONGKHO = db.TRONGKHOs.Find(id);
            if (tRONGKHO == null)
            {
                return HttpNotFound();
            }
            return View(tRONGKHO);
        }

        // POST: TRONGKHOes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STT,Tenkho,TenMH,Soluong,DVT,Dongia")] TRONGKHO tRONGKHO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRONGKHO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRONGKHO);
        }

        // GET: TRONGKHOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRONGKHO tRONGKHO = db.TRONGKHOs.Find(id);
            if (tRONGKHO == null)
            {
                return HttpNotFound();
            }
            return View(tRONGKHO);
        }

        // POST: TRONGKHOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRONGKHO tRONGKHO = db.TRONGKHOs.Find(id);
            db.TRONGKHOs.Remove(tRONGKHO);
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
