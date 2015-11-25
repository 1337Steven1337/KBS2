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
    public class PredefinedAnswersController : ApiController
    {
        private ServerContext db = new ServerContext();

        // GET: api/PredefinedAnswers
        public IQueryable<PredefinedAnswer> GetPredefinedAnswers()
        {
            return db.PredefinedAnswers;
        }

        // GET: api/PredefinedAnswers/5
        [ResponseType(typeof(PredefinedAnswer))]
        public async Task<IHttpActionResult> GetPredefinedAnswer(int id)
        {
            PredefinedAnswer predefinedAnswer = await db.PredefinedAnswers.FindAsync(id);
            if (predefinedAnswer == null)
            {
                return NotFound();
            }

            return Ok(predefinedAnswer);
        }

        // PUT: api/PredefinedAnswers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPredefinedAnswer(int id, PredefinedAnswer predefinedAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != predefinedAnswer.Id)
            {
                return BadRequest();
            }

            db.Entry(predefinedAnswer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PredefinedAnswerExists(id))
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

        // POST: api/PredefinedAnswers
        [ResponseType(typeof(PredefinedAnswer))]
        public async Task<IHttpActionResult> PostPredefinedAnswer(PredefinedAnswer predefinedAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PredefinedAnswers.Add(predefinedAnswer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = predefinedAnswer.Id }, predefinedAnswer);
        }

        // DELETE: api/PredefinedAnswers/5
        [ResponseType(typeof(PredefinedAnswer))]
        public async Task<IHttpActionResult> DeletePredefinedAnswer(int id)
        {
            PredefinedAnswer predefinedAnswer = await db.PredefinedAnswers.FindAsync(id);
            if (predefinedAnswer == null)
            {
                return NotFound();
            }

            db.PredefinedAnswers.Remove(predefinedAnswer);
            await db.SaveChangesAsync();

            return Ok(predefinedAnswer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PredefinedAnswerExists(int id)
        {
            return db.PredefinedAnswers.Count(e => e.Id == id) > 0;
        }
    }
}