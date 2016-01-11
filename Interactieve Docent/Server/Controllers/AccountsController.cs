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
    public class AccountsController : ApiControllerWithHub<EventHub>
    {
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
                Student = a.Student,
                Pincode_Id = a.Pincode_Id
            };

            return accounts;
        }

        // GET: api/Accounts/5
        [ResponseType(typeof(AccountDTO))]
        public async Task<IHttpActionResult> GetAccount(string id)
        {
            string password = LoginToken.Sha256(id);
            Account account = db.Accounts.Where(a => a.Password == password).FirstOrDefault();

            if (account == null)
            {
                return NotFound();
            }

            account.Token = LoginToken.Sha256(LoginToken.Generate(64));
            db.MarkAsModified(account);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(new AccountDTO(account));
        }

        // DELETE: api/Accounts/5
        [ResponseType(typeof(AccountDTO))]
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}