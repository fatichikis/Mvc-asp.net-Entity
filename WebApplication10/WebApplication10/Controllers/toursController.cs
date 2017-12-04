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
    public class toursController : Controller
    {
        private apiturisEntities db = new apiturisEntities();

        // GET: tours
        public ActionResult Index()
        {
            var tours = db.tours.Include(t => t.actividad).Include(t => t.clima).Include(t => t.lugare);
            return View(tours.ToList());
        }
 
        // GET: tours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tour tour = db.tours.Find(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }

        // GET: tours/Create
        public ActionResult Create()
        {
            ViewBag.IDactividad = new SelectList(db.actividads, "IDactividad", "Nombreactividad");
            ViewBag.IDclima = new SelectList(db.climas, "IDclima", "Nombreclima");
            ViewBag.IDestado = new SelectList(db.lugares, "IDestado", "Nombreestado");
            return View();
        }

        // POST: tours/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDtour,Nombretour,Descripciontour,IDestado,IDclima,IDactividad")] tour tour)
        {
            if (ModelState.IsValid)
            {
                db.tours.Add(tour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDactividad = new SelectList(db.actividads, "IDactividad", "Nombreactividad", tour.IDactividad);
            ViewBag.IDclima = new SelectList(db.climas, "IDclima", "Nombreclima", tour.IDclima);
            ViewBag.IDestado = new SelectList(db.lugares, "IDestado", "Nombreestado", tour.IDestado);
            return View(tour);
        }

        // GET: tours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tour tour = db.tours.Find(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDactividad = new SelectList(db.actividads, "IDactividad", "Nombreactividad", tour.IDactividad);
            ViewBag.IDclima = new SelectList(db.climas, "IDclima", "Nombreclima", tour.IDclima);
            ViewBag.IDestado = new SelectList(db.lugares, "IDestado", "Nombreestado", tour.IDestado);
            return View(tour);
        }

        // POST: tours/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDtour,Nombretour,Descripciontour,IDestado,IDclima,IDactividad")] tour tour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDactividad = new SelectList(db.actividads, "IDactividad", "Nombreactividad", tour.IDactividad);
            ViewBag.IDclima = new SelectList(db.climas, "IDclima", "Nombreclima", tour.IDclima);
            ViewBag.IDestado = new SelectList(db.lugares, "IDestado", "Nombreestado", tour.IDestado);
            return View(tour);
        }

        // GET: tours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tour tour = db.tours.Find(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }

        // POST: tours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tour tour = db.tours.Find(id);
            db.tours.Remove(tour);
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
