
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
    public class PlanController : ApiController
    {
        private GymWebAppContext db = new GymWebAppContext();
        // GET: api/Plan
        public IQueryable<Plan> GetPlan()
        {
            return db.Plan;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}