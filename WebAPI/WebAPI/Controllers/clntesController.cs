using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class clntesController : ApiController
    {
        private AGROSISEntities db = new AGROSISEntities();

        // GET: api/clntes
        public IQueryable<clntes> Getclntes()
        {
            return db.clntes;
        }

        // GET: api/clntes/5
        [ResponseType(typeof(clntes))]
        public IHttpActionResult Getclntes(string id)
        {
            clntes clntes = db.clntes.Find(id);
            if (clntes == null)
            {
                return NotFound();
            }

            return Ok(clntes);
        }

        // PUT: api/clntes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putclntes(string id, clntes clntes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clntes.clntes_idntfccion)
            {
                return BadRequest();
            }

            db.Entry(clntes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clntesExists(id))
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

        // POST: api/clntes
        [ResponseType(typeof(clntes))]
        public IHttpActionResult Postclntes(clntes clntes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.clntes.Add(clntes);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (clntesExists(clntes.clntes_idntfccion))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = clntes.clntes_idntfccion }, clntes);
        }

        // DELETE: api/clntes/5
        [ResponseType(typeof(clntes))]
        public IHttpActionResult Deleteclntes(string id)
        {
            clntes clntes = db.clntes.Find(id);
            if (clntes == null)
            {
                return NotFound();
            }

            db.clntes.Remove(clntes);
            db.SaveChanges();

            return Ok(clntes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool clntesExists(string id)
        {
            return db.clntes.Count(e => e.clntes_idntfccion == id) > 0;
        }
    }
}