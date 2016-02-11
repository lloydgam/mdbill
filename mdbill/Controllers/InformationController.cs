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
using mdbill.DAL;
using mdbill.Models;

namespace mdbill.Controllers
{
    public class InformationController : ApiController
    {
        private MdbillContext db = new MdbillContext();

        // GET: api/Information
        [Authorize]
        public IQueryable<Information> GetInformations()
        {
            return db.Informations;
        }

        // GET: api/Information/5
        [ResponseType(typeof(Information))]
        public IHttpActionResult GetInformation(int id)
        {
            Information information = db.Informations.Find(id);
            if (information == null)
            {
                return NotFound();
            }

            return Ok(information);
        }

        // PUT: api/Information/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInformation(int id, Information information)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != information.ID)
            {
                return BadRequest();
            }

            db.Entry(information).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InformationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(information);
        }

        // POST: api/Information
        [ResponseType(typeof(Information))]
        public IHttpActionResult PostInformation(Information information)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Informations.Add(information);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = information.ID }, information);
        }

        // DELETE: api/Information/5
        [ResponseType(typeof(Information))]
        public IHttpActionResult DeleteInformation(int id)
        {
            Information information = db.Informations.Find(id);
            if (information == null)
            {
                return NotFound();
            }

            db.Informations.Remove(information);
            db.SaveChanges();

            return Ok(information);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InformationExists(int id)
        {
            return db.Informations.Count(e => e.ID == id) > 0;
        }
    }
}