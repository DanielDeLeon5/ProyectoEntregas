using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Proyect.Models;

namespace MVC_Proyect.Controllers
{
    public class EntregasRepartidorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EntregasRepartidor
        public ActionResult Index()
        {
            var entregas = db.Entregas.Include(e => e.Repartidor);
            return View(entregas.ToList());
        }

        // GET: EntregasRepartidor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrega entrega = db.Entregas.Find(id);
            if (entrega == null)
            {
                return HttpNotFound();
            }
            return View(entrega);
        }

        // GET: EntregasRepartidor/Create
        public ActionResult Create()
        {
            ViewBag.RepartidorId = new SelectList(db.Repartidors, "Id", "Nombre");
            return View();
        }

        // POST: EntregasRepartidor/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UsuarioId,RepartidorId,DireccionOrigen,DireccionDestino,Producto,Descripcion,Indicaciones,Peso,NombreDestino,DpiDestino,PrecioPaquete,Fecha,Estado")] Entrega entrega)
        {
            if (ModelState.IsValid)
            {
                db.Entregas.Add(entrega);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RepartidorId = new SelectList(db.Repartidors, "Id", "Nombre", entrega.RepartidorId);
            return View(entrega);
        }

        // GET: EntregasRepartidor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrega entrega = db.Entregas.Find(id);
            if (entrega == null)
            {
                return HttpNotFound();
            }
            ViewBag.RepartidorId = new SelectList(db.Repartidors, "Id", "Nombre", entrega.RepartidorId);
            return View(entrega);
        }

        // POST: EntregasRepartidor/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UsuarioId,RepartidorId,DireccionOrigen,DireccionDestino,Producto,Descripcion,Indicaciones,Peso,NombreDestino,DpiDestino,PrecioPaquete,Fecha,Estado")] Entrega entrega)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrega).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RepartidorId = new SelectList(db.Repartidors, "Id", "Nombre", entrega.RepartidorId);
            return View(entrega);
        }

        // GET: EntregasRepartidor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrega entrega = db.Entregas.Find(id);
            if (entrega == null)
            {
                return HttpNotFound();
            }
            return View(entrega);
        }

        // POST: EntregasRepartidor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entrega entrega = db.Entregas.Find(id);
            db.Entregas.Remove(entrega);
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
