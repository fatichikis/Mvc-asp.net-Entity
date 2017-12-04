using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication10;

namespace WebApplication10.Controllers
{
    public class actividadsController : Controller
    {
        private apiturisEntities db = new apiturisEntities();

        // GET: actividads
        public ActionResult Index()
        {
            return View(db.actividads.ToList());
        }

        // GET: actividads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            actividad actividad = db.actividads.Find(id);
            if (actividad == null)
            {
                return HttpNotFound();
            }
            return View(actividad);
        }

        // GET: actividads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: actividads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDactividad,Nombreactividad,Descripcionactividad")] actividad actividad)
        {
            if (ModelState.IsValid)
            {
                db.actividads.Add(actividad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actividad);
        }

        // GET: actividads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            actividad actividad = db.actividads.Find(id);
            if (actividad == null)
            {
                return HttpNotFound();
            }
            return View(actividad);
        }

        // POST: actividads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDactividad,Nombreactividad,Descripcionactividad")] actividad actividad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actividad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actividad);
        }

        // GET: actividads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            actividad actividad = db.actividads.Find(id);
            if (actividad == null)
            {
                return HttpNotFound();
            }
            return View(actividad);
        }

        // POST: actividads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            actividad actividad = db.actividads.Find(id);
            db.actividads.Remove(actividad);
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
