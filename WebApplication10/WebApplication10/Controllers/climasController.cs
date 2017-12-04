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
    public class climasController : Controller
    {
        private apiturisEntities db = new apiturisEntities();

        // GET: climas
        public ActionResult Index()
        {
            return View(db.climas.ToList());
        }

        // GET: climas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clima clima = db.climas.Find(id);
            if (clima == null)
            {
                return HttpNotFound();
            }
            return View(clima);
        }

        // GET: climas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: climas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDclima,Nombreclima,Descripcionclima")] clima clima)
        {
            if (ModelState.IsValid)
            {
                db.climas.Add(clima);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clima);
        }

        // GET: climas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clima clima = db.climas.Find(id);
            if (clima == null)
            {
                return HttpNotFound();
            }
            return View(clima);
        }

        // POST: climas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDclima,Nombreclima,Descripcionclima")] clima clima)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clima).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clima);
        }

        // GET: climas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clima clima = db.climas.Find(id);
            if (clima == null)
            {
                return HttpNotFound();
            }
            return View(clima);
        }

        // POST: climas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            clima clima = db.climas.Find(id);
            db.climas.Remove(clima);
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
