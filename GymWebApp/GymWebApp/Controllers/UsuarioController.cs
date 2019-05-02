
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
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        private GymWebAppContext db = new GymWebAppContext();
        // GET: api/Plan
        public IQueryable<Usuario> GetUsuario()
        {
            return db.Usuario;
        }

      

        // POST api/Usuario
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult PostUsuario(Usuario Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Usuario.Add(Usuario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = Usuario.Id }, Usuario);
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsuario(int Id, Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != usuario.Id)
            {
                return BadRequest();
            }

            db.Entry(usuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(Id))
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
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult DeleteUsuario(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            db.Usuario.Remove(usuario);
            db.SaveChanges();

            return Ok(usuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsuarioExists(int Id)
        {
            return db.Usuario.Count(e => e.Id== Id) > 0;
        }
    }
}