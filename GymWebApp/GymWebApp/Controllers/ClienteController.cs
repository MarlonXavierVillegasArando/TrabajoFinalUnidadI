
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
    public class ClienteController : ApiController
    {
        private GymWebAppContext db = new GymWebAppContext();
        // GET: api/Cliente
        public IQueryable<Cliente> GetCliente()
        {
            return db.Cliente;
        }

        // GET api/<controller>/5
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult GetCliente(int Dni)
        {
            Cliente cliente = db.Cliente.Find(Dni);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
        // POST: api/Cliente
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult PostCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cliente.Add(cliente);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cliente.Id }, cliente);
        }
        // PUT: api/Tareas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente (int Id, Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != cliente.Id)
            {
                return BadRequest();
            }

            db.Entry(cliente).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(Id))
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
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult DeleteCliente(int id)
        {
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            db.Cliente.Remove(cliente);
            db.SaveChanges();

            return Ok(cliente);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TareaExists(int Id)
        {
            return db.Cliente.Count(e => e.Id == Id) > 0;
        }
    }
}