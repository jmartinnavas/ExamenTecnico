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
    public class ResidentesController : Controller
    {
        private pruebaTecnicaEntities db = new pruebaTecnicaEntities();

        // GET: Residentes
        public ActionResult Index()
        {
            var residentes = db.Residentes.Include(r => r.Finca1);
            return View(residentes.ToList());
        }

        // GET: Residentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Residentes residentes = db.Residentes.Find(id);
            if (residentes == null)
            {
                return HttpNotFound();
            }
            return View(residentes);
        }

        // GET: Residentes/Create
        public ActionResult Create()
        {
            var list = new SelectList(new[]
                                          {
                                              new {ID="",Name="--SELECCIONE EL PARENTESCO"},
                                              new {ID="ESPOSO(A)",Name="ESPOSO(A)"},
                                              new{ID="HIJO(A)",Name="HIJO(A)"},
                                               new{ID="HERMANO(A)",Name="HERMANO(A)"},
                                                new{ID="SOBRINO(A)",Name="SOBRINO(A)"},
                                          },
               "ID", "Name", 1);
            ViewData["list"] = list;
            ViewBag.finca = new SelectList(db.Finca, "codigo", "nombre");
            return View();
        }

        // POST: Residentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "documento,nombre,Apellido,contacto,parentesco,finca")] Residentes residentes)
        {
            if (ModelState.IsValid)
            {
                db.Residentes.Add(residentes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.finca = new SelectList(db.Finca, "codigo", "nombre", residentes.finca);
            return View(residentes);
        }

        // GET: Residentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Residentes residentes = db.Residentes.Find(id);
            if (residentes == null)
            {
                return HttpNotFound();
            }
            var list = new SelectList(new[]
                                         {
                                              new {ID="",Name="--SELECCIONE EL PARENTESCO"},
                                              new {ID="ESPOSO(A)",Name="ESPOSO(A)"},
                                              new{ID="HIJO(A)",Name="HIJO(A)"},
                                               new{ID="HERMANO(A)",Name="HERMANO(A)"},
                                                new{ID="SOBRINO(A)",Name="SOBRINO(A)"},
                                          },
              "ID", "Name", 1);
            ViewData["list"] = list;
            ViewBag.finca = new SelectList(db.Finca, "codigo", "nombre", residentes.finca);
            return View(residentes);
        }

        // POST: Residentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "documento,nombre,Apellido,contacto,parentesco,finca")] Residentes residentes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(residentes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.finca = new SelectList(db.Finca, "codigo", "nombre", residentes.finca);
            return View(residentes);
        }

        // GET: Residentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Residentes residentes = db.Residentes.Find(id);
            if (residentes == null)
            {
                return HttpNotFound();
            }
            return View(residentes);
        }

        // POST: Residentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Residentes residentes = db.Residentes.Find(id);
            db.Residentes.Remove(residentes);
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
