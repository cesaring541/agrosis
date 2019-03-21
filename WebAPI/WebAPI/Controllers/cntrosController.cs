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
    public class cntrosController : ApiController
    {
        private AGROSISEntities db = new AGROSISEntities();

        // GET: api/cntros
        public IQueryable<cntros> Getcntros()
        {
            return db.cntros;
        }

        // GET: api/cntros/5
        [ResponseType(typeof(cntros))]
        public IHttpActionResult Getcntros(string id)
        {
            cntros cntros = db.cntros.Find(id);
            if (cntros == null)
            {
                return NotFound();
            }

            return Ok(cntros);
        }

        // PUT: api/cntros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcntros(string id, cntros cntros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cntros.cntros_cdgo)
            {
                return BadRequest();
            }

            db.Entry(cntros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cntrosExists(id))
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

        // POST: api/cntros
        [ResponseType(typeof(cntros))]
        public IHttpActionResult Postcntros(cntros cntros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.cntros.Add(cntros);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (cntrosExists(cntros.cntros_cdgo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cntros.cntros_cdgo }, cntros);
        }

        // DELETE: api/cntros/5
        [ResponseType(typeof(cntros))]
        public IHttpActionResult Deletecntros(string id)
        {
            cntros cntros = db.cntros.Find(id);
            if (cntros == null)
            {
                return NotFound();
            }

            db.cntros.Remove(cntros);
            db.SaveChanges();

            return Ok(cntros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool cntrosExists(string id)
        {
            return db.cntros.Count(e => e.cntros_cdgo == id) > 0;
        }
    }
}