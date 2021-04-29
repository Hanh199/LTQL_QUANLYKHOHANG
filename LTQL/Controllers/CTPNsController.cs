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
    public class CTPNsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CTPNs
        public ActionResult Index()
        {
            return View(db.CTPNs.ToList());
        }

        // GET: CTPNs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPN cTPN = db.CTPNs.Find(id);
            if (cTPN == null)
            {
                return HttpNotFound();
            }
            return View(cTPN);
        }

        // GET: CTPNs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CTPNs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STTPN,MaPN,TenPN,TenMH,TenKH,Soluong,Dongia")] CTPN cTPN)
        {
            if (ModelState.IsValid)
            {
                db.CTPNs.Add(cTPN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cTPN);
        }

        // GET: CTPNs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPN cTPN = db.CTPNs.Find(id);
            if (cTPN == null)
            {
                return HttpNotFound();
            }
            return View(cTPN);
        }

        // POST: CTPNs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STTPN,MaPN,TenPN,TenMH,TenKH,Soluong,Dongia")] CTPN cTPN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cTPN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cTPN);
        }

        // GET: CTPNs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPN cTPN = db.CTPNs.Find(id);
            if (cTPN == null)
            {
                return HttpNotFound();
            }
            return View(cTPN);
        }

        // POST: CTPNs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CTPN cTPN = db.CTPNs.Find(id);
            db.CTPNs.Remove(cTPN);
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
