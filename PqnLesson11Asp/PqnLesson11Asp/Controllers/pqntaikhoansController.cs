using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PqnLesson11Asp.Models;

namespace PqnLesson11Asp.Controllers
{
    public class pqntaikhoansController : Controller
    {
        private PqnLesson11DbsEntities db = new PqnLesson11DbsEntities();

        // GET: pqntaikhoans
        public ActionResult Index()
        {
            return View(db.pqntaikhoans.ToList());
        }

        // GET: pqntaikhoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqntaikhoan pqntaikhoan = db.pqntaikhoans.Find(id);
            if (pqntaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(pqntaikhoan);
        }

        // GET: pqntaikhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pqntaikhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PqnId,PqnUseName,PqnPassword,PqnFullName,PqnAge,PqnEmail,PqnPhone,PqnStatus")] pqntaikhoan pqntaikhoan)
        {
            if (ModelState.IsValid)
            {
                db.pqntaikhoans.Add(pqntaikhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pqntaikhoan);
        }

        // GET: pqntaikhoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqntaikhoan pqntaikhoan = db.pqntaikhoans.Find(id);
            if (pqntaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(pqntaikhoan);
        }

        // POST: pqntaikhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PqnId,PqnUseName,PqnPassword,PqnFullName,PqnAge,PqnEmail,PqnPhone,PqnStatus")] pqntaikhoan pqntaikhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqntaikhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pqntaikhoan);
        }

        // GET: pqntaikhoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqntaikhoan pqntaikhoan = db.pqntaikhoans.Find(id);
            if (pqntaikhoan == null)
            {
                return HttpNotFound();
            }
            return View(pqntaikhoan);
        }

        // POST: pqntaikhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pqntaikhoan pqntaikhoan = db.pqntaikhoans.Find(id);
            db.pqntaikhoans.Remove(pqntaikhoan);
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
