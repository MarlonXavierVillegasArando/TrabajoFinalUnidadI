using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GymWebApp.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GymWebApp.Controllers
{
    public class EntrenadorController : ApiController
    {
        private GymWebAppContext db = new GymWebAppContext();
        // GET: api/Entrenador
        public IQueryable<Entrenador> GetEntrenador()
        {
            return db.Entrenador;
        }

   

        // POST api/Entrenador
        [ResponseType(typeof(Entrenador))]
        public IHttpActionResult PostEntrenador(Entrenador entrenador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entrenador.Add(entrenador);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = entrenador.Id }, entrenador);
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEntrenador(int Id, Entrenador entrenador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != entrenador.Id)
            {
                return BadRequest();
            }

            db.Entry(entrenador).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/<controller>/5
        [ResponseType(typeof(Entrenador))]
        public IHttpActionResult DeletEntrenador(int id)
        {
            Entrenador entrenador = db.Entrenador.Find(id);
            if (entrenador == null)
            {
                return NotFound();
            }

            db.Entrenador.Remove(entrenador);
            db.SaveChanges();

            return Ok(entrenador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlanExists(int Id)
        {
            return db.Entrenador.Count(e => e.Id == Id) > 0;
        }
    }
}