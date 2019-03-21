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
    public class enc_vlesController : ApiController
    {
        private AGROSISEntities db = new AGROSISEntities();

        // GET: api/enc_vles
        public IQueryable<enc_vles> Getenc_vles()
        {
            return db.enc_vles;
        }

        // GET: api/enc_vles/5
        [ResponseType(typeof(enc_vles))]
        public IHttpActionResult Getenc_vles(int id)
        {
            enc_vles enc_vles = db.enc_vles.Find(id);
            if (enc_vles == null)
            {
                return NotFound();
            }

            return Ok(enc_vles);
        }

        // PUT: api/enc_vles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putenc_vles(int id, enc_vles enc_vles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != enc_vles.enc_vles_nmro)
            {
                return BadRequest();
            }

            db.Entry(enc_vles).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!enc_vlesExists(id))
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

        // POST: api/enc_vles
        [ResponseType(typeof(enc_vles))]
        public IHttpActionResult Postenc_vles(enc_vles enc_vles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.enc_vles.Add(enc_vles);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = enc_vles.enc_vles_nmro }, enc_vles);
        }

        // DELETE: api/enc_vles/5
        [ResponseType(typeof(enc_vles))]
        public IHttpActionResult Deleteenc_vles(int id)
        {
            enc_vles enc_vles = db.enc_vles.Find(id);
            if (enc_vles == null)
            {
                return NotFound();
            }

            db.enc_vles.Remove(enc_vles);
            db.SaveChanges();

            return Ok(enc_vles);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool enc_vlesExists(int id)
        {
            return db.enc_vles.Count(e => e.enc_vles_nmro == id) > 0;
        }
    }
}