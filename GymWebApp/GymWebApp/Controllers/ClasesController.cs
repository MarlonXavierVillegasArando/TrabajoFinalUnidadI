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
        // GET: api/clases
        public IQueryable<Clases> GetClases()
        {
            return db.Clases;
        }

        // GET api/clases/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/clases
        public void Post([FromBody]string value)
        {
        }

        // PUT api/clases/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/clases/5
        public void Delete(int id)
        {
        }
    }
}