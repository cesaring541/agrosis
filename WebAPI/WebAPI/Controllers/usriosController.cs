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
    public class usriosController : ApiController
    {
        private AGROSISEntities db = new AGROSISEntities();

        // GET: api/usrios
        public IQueryable<usrios> Getusrios()
        {
            return db.usrios;
        }

        // GET: api/usrios/5
        [ResponseType(typeof(usrios))]
        public IHttpActionResult Getusrios(string id)
        {
            usrios usrios = db.usrios.Find(id);
            if (usrios == null)
            {
                return NotFound();
            }

            return Ok(usrios);
        }

        // PUT: api/usrios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putusrios(string id, usrios usrios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usrios.usrios_cdgo)
            {
                return BadRequest();
            }

            db.Entry(usrios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!usriosExists(id))
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

        // POST: api/usrios
        [ResponseType(typeof(usrios))]
        public IHttpActionResult Postusrios(usrios usrios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.usrios.Add(usrios);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (usriosExists(usrios.usrios_cdgo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = usrios.usrios_cdgo }, usrios);
        }

        // DELETE: api/usrios/5
        [ResponseType(typeof(usrios))]
        public IHttpActionResult Deleteusrios(string id)
        {
            usrios usrios = db.usrios.Find(id);
            if (usrios == null)
            {
                return NotFound();
            }

            db.usrios.Remove(usrios);
            db.SaveChanges();

            return Ok(usrios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool usriosExists(string id)
        {
            return db.usrios.Count(e => e.usrios_cdgo == id) > 0;
        }

        // GET: api/login/5
        [ResponseType(typeof(usrios))]
        [Route("api/login/")]
        public IHttpActionResult Getlogin(string usrios_cdgo)
        {
            usrios usrios = db.usrios.Find(usrios_cdgo);
            if (usrios == null)
            {
                return NotFound();
            }

            return Ok(usrios);
        }
    }
}