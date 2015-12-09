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
    public class AccountsController : ApiController
    {
        private IDocentAppContext db = new ServerContext();

        public AccountsController() { }
        public AccountsController(IDocentAppContext context)
        {
            this.db = context;
        } 

        // GET: api/Accounts
        public IQueryable<AccountDTO> GetAccounts()
        {
            var accounts = from a in db.Accounts select new AccountDTO()  {
                Id = a.Id,
                Student = a.Student
            };

            return accounts;
        }

        // GET: api/Accounts/5
        [ResponseType(typeof(AccountDTO))]
        public AccountDTO GetAccount(int id)
        {
            var account = from a in db.Accounts
                        where a.Id == id
                        select new AccountDTO()
                        {
                            Id = a.Id,
                            Student = a.Student,
                        };

            return account.FirstOrDefault(x => x.Id == x.Id);
        }

        // PUT: api/Accounts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAccount(int id, Account account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != account.Id)
            {
                return BadRequest();
            }

            db.MarkAsModified(account);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(id))
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

        // POST: api/Accounts
        [ResponseType(typeof(AccountDTO))]
        public async Task<IHttpActionResult> PostAccount([FromBody] Account account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Accounts.Add(account);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = account.Id }, new AccountDTO(account));
        }

        // DELETE: api/Accounts/5
        [ResponseType(typeof(Account))]
        public async Task<IHttpActionResult> DeleteAccount(int id)
        {
            Account account = await db.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }

            db.Accounts.Remove(account);
            await db.SaveChangesAsync();

            return Ok(account);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AccountExists(int id)
        {
            return db.Accounts.Count(e => e.Id == id) > 0;
        }
    }
}