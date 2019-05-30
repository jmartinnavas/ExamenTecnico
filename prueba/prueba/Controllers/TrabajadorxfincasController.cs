using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using prueba;

namespace prueba.Controllers
{
    public class TrabajadorxfincasController : Controller
    {
        private pruebaTecnicaEntities db = new pruebaTecnicaEntities();

        // GET: Trabajadorxfincas
        public ActionResult Index()
        {
            return View(db.Trabajadorxfinca.ToList());
        }

        // GET: Trabajadorxfincas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabajadorxfinca trabajadorxfinca = db.Trabajadorxfinca.Find(id);
            if (trabajadorxfinca == null)
            {
                return HttpNotFound();
            }
            return View(trabajadorxfinca);
        }

        // GET: Trabajadorxfincas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabajadorxfincas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo,documento")] Trabajadorxfinca trabajadorxfinca)
        {
            if (ModelState.IsValid)
            {
                db.Trabajadorxfinca.Add(trabajadorxfinca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trabajadorxfinca);
        }

        // GET: Trabajadorxfincas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabajadorxfinca trabajadorxfinca = db.Trabajadorxfinca.Find(id);
            if (trabajadorxfinca == null)
            {
                return HttpNotFound();
            }
            return View(trabajadorxfinca);
        }

        // POST: Trabajadorxfincas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo,documento")] Trabajadorxfinca trabajadorxfinca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trabajadorxfinca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trabajadorxfinca);
        }

        // GET: Trabajadorxfincas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabajadorxfinca trabajadorxfinca = db.Trabajadorxfinca.Find(id);
            if (trabajadorxfinca == null)
            {
                return HttpNotFound();
            }
            return View(trabajadorxfinca);
        }

        // POST: Trabajadorxfincas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trabajadorxfinca trabajadorxfinca = db.Trabajadorxfinca.Find(id);
            db.Trabajadorxfinca.Remove(trabajadorxfinca);
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
