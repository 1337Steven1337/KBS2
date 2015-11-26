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
using System.IO;
using System.Web;
using Server;
using Server.Hubs;
using Server.Models.Context;

namespace Server.Controllers
{
    public class ListsController : ApiControllerWithHub<EventHub>
    {
        private IDocentAppContext db = new ServerContext();

        public ListsController() { }
        public ListsController(IDocentAppContext context)
        {
            this.db = context;
        }

        // GET: api/Lists
        public IQueryable<ListDTO> GetLists()
        {
            var QuestionLists = from q in db.QuestionLists
                        select new ListDTO() {
                Id = q.Id,
                Name = q.Name,
                Questions = q.Questions.Select(C => new QuestionDTO{ Id = C.Id }).ToList<QuestionDTO>()
            };

            return QuestionLists;
        }

        // GET: api/Lists/5
        [ResponseType(typeof(ListDTO))]
        public ListDTO GetList(int id)
        {
            var lists = from q in db.QuestionLists
                        where q.Id == id
                        select new ListDTO()
                        {
                            Id = q.Id,
                            Name = q.Name,
                            Questions = q.Questions.Select(C => new QuestionDTO { Id = C.Id, Text = C.Text, Time = C.Time, Points = C.Points, List_Id = C.List_Id, PredefinedAnswers = (C.PredefinedAnswers.Select(V => new PredefinedAnswerDTO { Id = V.Id, Text = V.Text, Question_Id = V.Question.Id })).ToList<PredefinedAnswerDTO>()}).ToList<QuestionDTO>()
                        };

            return lists.FirstOrDefault(x => x.Id == x.Id);
        }

        // PUT: api/Lists/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutList(int id, QuestionList list)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != list.Id)
            {
                return BadRequest();
            }

            db.MarkAsModified(list);

            try
            {
                await db.SaveChangesAsync();

                this.getSubscribed(list.Id).ListUpdated(new ListDTO(list));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListExists(id))
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

        // POST: api/Lists
        [ResponseType(typeof(QuestionList))]
        public async Task<IHttpActionResult> PostList([FromBody] QuestionList list)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.QuestionLists.Add(list);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = list.Id }, list);
        }

        // DELETE: api/Lists/5
        [ResponseType(typeof(QuestionList))]
        public async Task<IHttpActionResult> DeleteList(int id)
        {
            QuestionList list = await db.QuestionLists.FindAsync(id);
            if (list == null)
            {
                return NotFound();
            }

            db.QuestionLists.Remove(list);
            await db.SaveChangesAsync();

            return Ok(list);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ListExists(int id)
        {
            return db.QuestionLists.Count(e => e.Id == id) > 0;
        }
    }
}