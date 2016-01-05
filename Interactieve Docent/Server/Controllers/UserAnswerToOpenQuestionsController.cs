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
    public class UserAnswerToOpenQuestionsController : ApiControllerWithHub<EventHub>
    {
        private IDocentAppContext db = new ServerContext();

        public UserAnswerToOpenQuestionsController() { }
        public UserAnswerToOpenQuestionsController(IDocentAppContext context)
        {
            this.db = context;
        }

        // GET: api/UserAnswerToOpenQuestions
        public IQueryable<UserAnswerToOpenQuestionDTO> GetUserAnswers()
        {
            var ua = from q in db.UserAnswerToOpenQuestions
                     select new UserAnswerToOpenQuestionDTO()
                     {
                         Id = q.Id,
                         Question_Id = q.Question.Id,
                         Answer = q.Answer,
                         Student = q.Student                        
                     };

            return ua;
        }

        // GET: api/UserAnswerToOpenQuestions/5
        [ResponseType(typeof(UserAnswerToOpenQuestionDTO))]
        public UserAnswerToOpenQuestionDTO GetList(int id)
        {
            var userAnswerToOpenQuestions = from ua in db.UserAnswerToOpenQuestions
                              where ua.Id == id
                              select new UserAnswerToOpenQuestionDTO()
                              {
                                Id = ua.Id,
                                Question_Id = ua.Question.Id,
                                Answer = ua.Answer,
                                Student = ua.Student
                              };

            return userAnswerToOpenQuestions.FirstOrDefault(x => x.Id == x.Id);
        }

        // PUT: api/UserAnswerToOpenQuestions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUserAnswerToOpenQuestion(int id, UserAnswerToOpenQuestion userAnswer)
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

                OpenQuestion question = db.OpenQuestions.Find(userAnswer.Question_Id);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserAnswerToOpenQuestionExists(id))
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

        // POST: api/UserAnswerToOpenQuestions
        [ResponseType(typeof(UserAnswerToOpenQuestion))]
        public async Task<IHttpActionResult> PostUserAnswer(UserAnswerToOpenQuestion userAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserAnswerToOpenQuestions.Add(userAnswer);
            await db.SaveChangesAsync();

            OpenQuestion question = db.OpenQuestions.Find(userAnswer.Question_Id);

            return CreatedAtRoute("DefaultApi", new { id = userAnswer.Id }, userAnswer);
        }

        // DELETE: api/UserAnswerToOpenQuestions/5
        [ResponseType(typeof(UserAnswerToOpenQuestion))]
        public async Task<IHttpActionResult> DeleteUserAnswerToOpenQuestion(int id)
        {
            UserAnswerToOpenQuestion userAnswer = await db.UserAnswerToOpenQuestions.FindAsync(id);
            if (userAnswer == null)
            {
                return NotFound();
            }

            db.UserAnswerToOpenQuestions.Remove(userAnswer);
            await db.SaveChangesAsync();

            OpenQuestion question = db.OpenQuestions.Find(userAnswer.Question_Id);

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

        private bool UserAnswerToOpenQuestionExists(int id)
        {
            return db.UserAnswerToOpenQuestions.Count(e => e.Id == id) > 0;
        }
    }
}