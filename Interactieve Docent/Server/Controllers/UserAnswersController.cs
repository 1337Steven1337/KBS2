using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Server.Models;
using Server.Models.DTO;
using Server.Models.Context;
using Server;
using Server.Hubs;

namespace Server.Controllers
{
    public class UserAnswersController : ApiControllerWithHub<EventHub>
    {
        public UserAnswersController() { }
        public UserAnswersController(IDocentAppContext context)
        {
            this.db = context;
        }

        // GET: api/UserAnswers
        public IQueryable<UserAnswerDTO> GetUserAnswers()
        {
            var ua = from q in db.UserAnswers
                     select new UserAnswerDTO()
                     {
                         Id = q.Id,
                         Question_Id = q.Question.Id,
                         _PredefinedAnswer = q.PredefinedAnswer,
                         Pincode_Id = q.Pincode_Id
                     };

            return ua;
        }

        // GET: api/UserAnswers/5
        [ResponseType(typeof(UserAnswerDTO))]
        public UserAnswerDTO GetList(int id)
        {
            var userAnswers = from ua in db.UserAnswers
                              where ua.Id == id
                              select new UserAnswerDTO()
                              {
                                  Id = ua.Id,
                                  Question_Id = ua.Question.Id,
                                  _PredefinedAnswer = ua.PredefinedAnswer,
                                  Pincode_Id = ua.Pincode_Id
                              };

            return userAnswers.FirstOrDefault(x => x.Id == x.Id);
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

            db.MarkAsModified(userAnswer);

            try
            {
                await db.SaveChangesAsync();

                Question question = db.Questions.Find(userAnswer.Question_Id);
                this.getSubscribed("List-" + question.List_Id).UserAnswerUpdated(new UserAnswerDTO(userAnswer));
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

            Question question = db.Questions.Find(userAnswer.Question_Id);
            this.getSubscribed("List-" + question.List_Id).UserAnswerAdded(new UserAnswerDTO(userAnswer));

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

            Question question = db.Questions.Find(userAnswer.Question_Id);
            this.getSubscribed("List-" + question.List_Id).UserAnswerRemoved(new UserAnswerDTO(userAnswer));

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