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
    public class EmpresaController : ApiController
    {
        private GymWebAppContext db = new GymWebAppContext();
        // GET: api/Empresa
        public IQueryable<Empresa> GetEmpresa()
        {
            return db.Empresa;
        }
        

        // POST: api/Empresa
        [ResponseType(typeof(Empresa))]
        public IHttpActionResult PostEmpresa(Empresa empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Empresa.Add(empresa);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empresa.Id }, empresa);
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmpresa(int Id, Empresa empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != empresa.Id)
            {
                return BadRequest();
            }

            db.Entry(empresa).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(Id))
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
        public IHttpActionResult DeletEmpresa(int id)
        {
            Empresa empresa = db.Empresa.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }

            db.Empresa.Remove(empresa);
            db.SaveChanges();

            return Ok(empresa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmpresaExists(int Id)
        {
            return db.Empresa.Count(e => e.Id == Id) > 0;
        }
    }
}