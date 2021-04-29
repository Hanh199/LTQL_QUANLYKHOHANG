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
    public class CTPXesController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CTPXes
        public ActionResult Index()
        {
            return View(db.CTPXs.ToList());
        }

        // GET: CTPXes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPX cTPX = db.CTPXs.Find(id);
            if (cTPX == null)
            {
                return HttpNotFound();
            }
            return View(cTPX);
        }

        // GET: CTPXes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CTPXes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STTPX,MaPX,TenPX,TenMH,TenNCC,Soluong,Dongia")] CTPX cTPX)
        {
            if (ModelState.IsValid)
            {
                db.CTPXs.Add(cTPX);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cTPX);
        }

        // GET: CTPXes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPX cTPX = db.CTPXs.Find(id);
            if (cTPX == null)
            {
                return HttpNotFound();
            }
            return View(cTPX);
        }

        // POST: CTPXes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STTPX,MaPX,TenPX,TenMH,TenNCC,Soluong,Dongia")] CTPX cTPX)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cTPX).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cTPX);
        }

        // GET: CTPXes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPX cTPX = db.CTPXs.Find(id);
            if (cTPX == null)
            {
                return HttpNotFound();
            }
            return View(cTPX);
        }

        // POST: CTPXes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CTPX cTPX = db.CTPXs.Find(id);
            db.CTPXs.Remove(cTPX);
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
