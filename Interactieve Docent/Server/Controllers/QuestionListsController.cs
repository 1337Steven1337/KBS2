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
using Server.Hubs;

namespace Server.Controllers
{
    public class QuestionListsController : ApiControllerWithHub<EventHub>
    {
        private IDocentAppContext db = new ServerContext();
         
        public QuestionListsController() { }
        public QuestionListsController(IDocentAppContext context)
        {
            this.db = context;
        }

        // GET: api/QuestionLists
        public IQueryable<ListDTO> GetLists()
        {
            var QuestionLists = from q in db.QuestionLists
                                select new ListDTO()
                                {
                                    Id = q.Id,
                                    Name = q.Name,
                                    Questions = q.Questions.Select(C => new QuestionDTO { Id = C.Id }).ToList<QuestionDTO>()
                                };

            return QuestionLists;
        }

        // GET: api/QuestionLists/5
        [ResponseType(typeof(ListDTO))]
        public ListDTO GetList(int id)
        {
            var lists = from q in db.QuestionLists
                        where q.Id == id
                        select new ListDTO()
                        {
                            Id = q.Id,
                            Name = q.Name,
                            Questions = q.Questions.Select(C => new QuestionDTO { Id = C.Id, Text = C.Text, Time = C.Time, Points = C.Points, List_Id = C.List_Id, PredefinedAnswers = (C.PredefinedAnswers.Select(V => new PredefinedAnswerDTO { Id = V.Id, Text = V.Text, Question_Id = V.Question.Id })).ToList<PredefinedAnswerDTO>() }).ToList<QuestionDTO>()
                        };

            return lists.FirstOrDefault(x => x.Id == x.Id);
        }

        // PUT: api/QuestionLists/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutQuestionList(int id, QuestionList questionList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != questionList.Id)
            {
                return BadRequest();
            }

            db.MarkAsModified(questionList);

            try
            {
                await db.SaveChangesAsync();

                this.getSubscribed("lists").QuestionListUpdated(new ListDTO(questionList));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionListExists(id))
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

        // POST: api/QuestionLists
        [ResponseType(typeof(QuestionList))]
        public async Task<IHttpActionResult> PostQuestionList(QuestionList questionList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.QuestionLists.Add(questionList);
            await db.SaveChangesAsync();

            this.getSubscribed("lists").QuestionListAdded(new ListDTO(questionList));

            return CreatedAtRoute("DefaultApi", new { id = questionList.Id }, questionList);
        }

        // DELETE: api/QuestionLists/5
        [ResponseType(typeof(QuestionList))]
        public async Task<IHttpActionResult> DeleteQuestionList(int id)
        {
            QuestionList questionList = await db.QuestionLists.FindAsync(id);
            if (questionList == null)
            {
                return NotFound();
            }

            db.QuestionLists.Remove(questionList);
            await db.SaveChangesAsync();

            this.getSubscribed("lists").QuestionListRemoved(new ListDTO(questionList));

            return Ok(questionList);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuestionListExists(int id)
        {
            return db.QuestionLists.Count(e => e.Id == id) > 0;
        }
    }
}