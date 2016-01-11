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
using Server.Models.DTO;

namespace Server.Controllers
{
    public class OpenQuestionsController : ApiControllerWithHub<Hubs.EventHub>
    {
        // GET: api/OpenQuestions
        public IQueryable<OpenQuestionDTO> GetOpenQuestions()
        {
            var OpenQuestions = from q in db.OpenQuestions
                                select new OpenQuestionDTO()
                                {
                                    Id = q.Id,
                                    Text = q.Text,
                                };

            return OpenQuestions;
        }

        // GET: api/OpenQuestions/5
        [ResponseType(typeof(OpenQuestion))]
        public async Task<IHttpActionResult> GetOpenQuestion(int id)
        {
            OpenQuestion openQuestion = await db.OpenQuestions.FindAsync(id);
            if (openQuestion == null)
            {
                return NotFound();
            }

            return Ok(openQuestion);
        }

        // PUT: api/OpenQuestions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOpenQuestion(int id, OpenQuestion openQuestion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != openQuestion.Id)
            {
                return BadRequest();
            }

            db.MarkAsModified(openQuestion);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpenQuestionExists(id))
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

        // POST: api/OpenQuestions
        [ResponseType(typeof(OpenQuestion))]
        public async Task<IHttpActionResult> PostOpenQuestion(OpenQuestion openQuestion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OpenQuestions.Add(openQuestion);
            await db.SaveChangesAsync();

            this.getSubscribed("Code-" + openQuestion.Pincode_Id).OpenQuestionAdded(new OpenQuestionDTO(openQuestion));

            return CreatedAtRoute("DefaultApi", new { id = openQuestion.Id }, openQuestion);
        }

        // DELETE: api/OpenQuestions/5
        [ResponseType(typeof(OpenQuestion))]
        public async Task<IHttpActionResult> DeleteOpenQuestion(int id)
        {
            OpenQuestion openQuestion = await db.OpenQuestions.FindAsync(id);
            if (openQuestion == null)
            {
                return NotFound();
            }

            db.OpenQuestions.Remove(openQuestion);
            await db.SaveChangesAsync();

            return Ok(openQuestion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OpenQuestionExists(int id)
        {
            return db.OpenQuestions.Count(e => e.Id == id) > 0;
        }
    }
}