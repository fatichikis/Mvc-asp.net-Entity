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
    public class lugaresController : Controller
    {
        private apiturisEntities db = new apiturisEntities();

        // GET: lugares
        public ActionResult Index()
        {
            return View(db.lugares.ToList());
        }

        // GET: lugares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lugare lugare = db.lugares.Find(id);
            if (lugare == null)
            {
                return HttpNotFound();
            }
            return View(lugare);
        }

        // GET: lugares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: lugares/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDestado,Nombreestado,Descripcionestado")] lugare lugare)
        {
            if (ModelState.IsValid)
            {
                db.lugares.Add(lugare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lugare);
        }

        // GET: lugares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lugare lugare = db.lugares.Find(id);
            if (lugare == null)
            {
                return HttpNotFound();
            }
            return View(lugare);
        }

        // POST: lugares/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDestado,Nombreestado,Descripcionestado")] lugare lugare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lugare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lugare);
        }

        // GET: lugares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lugare lugare = db.lugares.Find(id);
            if (lugare == null)
            {
                return HttpNotFound();
            }
            return View(lugare);
        }

        // POST: lugares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            lugare lugare = db.lugares.Find(id);
            db.lugares.Remove(lugare);
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
