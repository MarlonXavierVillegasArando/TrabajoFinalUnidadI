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
    public class ClasesController : ApiController
    {
        private GymWebAppContext db = new GymWebAppContext();
        // GET: api/Clases
        public IQueryable<Clases> GetClases()
        {
            return db.Clases;
        }


        // POST: api/Clases
        [ResponseType(typeof(Clases))]
        public IHttpActionResult PostClases(Clases clases)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clases.Add(clases);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = clases.Id }, clases);
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClases(int Id, Clases clases)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != clases.Id)
            {
                return BadRequest();
            }

            db.Entry(clases).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClasesExists(Id))
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
        [ResponseType(typeof(Clases))]
        public IHttpActionResult DeleteClases(int id)
        {
            Clases clases = db.Clases.Find(id);
            if (clases == null)
            {
                return NotFound();
            }

            db.Clases.Remove(clases);
            db.SaveChanges();

            return Ok(clases);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClasesExists(int Id)
        {
            return db.Clases.Count(e => e.Id == Id) > 0;
        }
    }
}