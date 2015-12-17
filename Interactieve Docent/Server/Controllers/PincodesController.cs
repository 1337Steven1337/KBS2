using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Server.Models;
using Server.Models.Context;

namespace Server.Controllers
{
    public class PincodesController : ApiController
    {
        private ServerContext db = new ServerContext();

        // GET: api/Pincodes
        public IQueryable<Pincode> GetPincodes()
        {
            return db.Pincodes;
        }

        // GET: api/Pincodes/5
        [ResponseType(typeof(Pincode))]
        public async Task<IHttpActionResult> GetPincode(string id)
        {
            Pincode pincode = await db.Pincodes.FindAsync(id);
            if (pincode == null)
            {
                return NotFound();
            }

            return Ok(pincode);
        }

        // PUT: api/Pincodes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPincode(string id, Pincode pincode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pincode.Id)
            {
                return BadRequest();
            }

            db.Entry(pincode).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PincodeExists(id))
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

        // POST: api/Pincodes
        [ResponseType(typeof(Pincode))]
        public async Task<IHttpActionResult> PostPincode(Pincode pincode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pincodes.Add(pincode);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pincode.Id }, pincode);
        }

        // DELETE: api/Pincodes/5
        [ResponseType(typeof(Pincode))]
        public async Task<IHttpActionResult> DeletePincode(int id)
        {
            Pincode pincode = await db.Pincodes.FindAsync(id);
            if (pincode == null)
            {
                return NotFound();
            }

            db.Pincodes.Remove(pincode);
            await db.SaveChangesAsync();

            return Ok(pincode);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PincodeExists(string id)
        {
            return db.Pincodes.Count(e => e.Id == id) > 0;
        }
    }
}