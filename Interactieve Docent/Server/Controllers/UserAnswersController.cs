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
using Server.Models.DTO;

namespace Server.Controllers
{
    public class UserAnswersController : ApiController
    {
        private ServerContext db = new ServerContext();

        // GET: api/UserAnswers
        public IQueryable<UserAnswerDTO> GetUserAnswers()
        {
            var ua = from q in db.UserAnswers
                     select new UserAnswerDTO()
                     {
                         Id = q.Id
                     };

            return ua;
        }

        // GET: api/UserAnswers/5
        [ResponseType(typeof(UserAnswerDTO))]
        public async Task<IHttpActionResult> GetUserAnswer(int id)
        {
            UserAnswer userAnswer = await db.UserAnswers.FindAsync(id);

            if (userAnswer == null)
            {
                return NotFound();
            }

            UserAnswerDTO uaDTO = new UserAnswerDTO(userAnswer);
            return Ok(uaDTO);
        }

        // PUT: api/UserAnswers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserAnswer(int id, UserAnswer userAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userAnswer.Id)
            {
                return BadRequest();
            }

            db.Entry(userAnswer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserAnswerExists(id))
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

        // POST: api/UserAnswers
        [ResponseType(typeof(UserAnswer))]
        public async Task<IHttpActionResult> PostUserAnswer(UserAnswer userAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserAnswers.Add(userAnswer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = userAnswer.Id }, userAnswer);
        }

        // DELETE: api/UserAnswers/5
        [ResponseType(typeof(UserAnswer))]
        public async Task<IHttpActionResult> DeleteUserAnswer(int id)
        {
            UserAnswer userAnswer = await db.UserAnswers.FindAsync(id);
            if (userAnswer == null)
            {
                return NotFound();
            }

            db.UserAnswers.Remove(userAnswer);
            await db.SaveChangesAsync();

            return Ok(userAnswer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserAnswerExists(int id)
        {
            return db.UserAnswers.Count(e => e.Id == id) > 0;
        }
    }
}