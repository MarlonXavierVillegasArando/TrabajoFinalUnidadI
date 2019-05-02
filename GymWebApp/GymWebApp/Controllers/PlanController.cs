
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


        // POST api/Plan
        [ResponseType(typeof(Plan))]
        public IHttpActionResult PostPlan(Plan plan )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Plan.Add(plan);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = plan.Id }, plan);
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPlan(int IdPlan, Plan plan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (IdPlan != plan.Id)
            {
                return BadRequest();
            }

            db.Entry(plan).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(IdPlan))
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
        [ResponseType(typeof(Plan))]
        public IHttpActionResult DeletePlan(int id)
        {
            Plan plan = db.Plan.Find(id);
            if (plan == null)
            {
                return NotFound();
            }

            db.Plan.Remove(plan);
            db.SaveChanges();

            return Ok(plan);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlanExists(int Idplan)
        {
            return db.Plan.Count(e => e.Id == Idplan) > 0;
        }
    }
}