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
using System.Security.Cryptography;
using System.Text;

namespace Server.Controllers
{
    public class TokensController : ApiController
    {
        private ServerContext db = new ServerContext();
        private static readonly char[] AvailableCharacters = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        // GET: api/Tokens
        public IQueryable<Token> GetTokens()
        {
            return db.Tokens;
        }

        // GET: api/Tokens/5
        [ResponseType(typeof(Token))]
        public async Task<IHttpActionResult> GetToken(int id)
        {
            Token token = await db.Tokens.FindAsync(id);
            if (token == null)
            {
                return NotFound();
            }

            return Ok(token);
        }

        // PUT: api/Tokens/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutToken(int id, Token token)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != token.Id)
            {
                return BadRequest();
            }

            db.Entry(token).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TokenExists(id))
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

        // POST: api/Tokens
        [ResponseType(typeof(Token))]
        public async Task<IHttpActionResult> PostToken(Token token)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            char[] identifier = new char[5];
            byte[] randomData = new byte[5];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomData);
            }

            for (int idx = 0; idx < identifier.Length; idx++)
            {
                int pos = randomData[idx] % AvailableCharacters.Length;
                identifier[idx] = AvailableCharacters[pos];
            }

            string Token = new string(identifier);
            SHA256 hash = SHA256Managed.Create();

            String.Join("", hash
            .ComputeHash(Encoding.UTF8.GetBytes(Token))
            .Select(item => item.ToString("x2")));

            token.Value = Token;
            db.Tokens.Add(token);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = token.Id }, token);
        }

        // DELETE: api/Tokens/5
        [ResponseType(typeof(Token))]
        public async Task<IHttpActionResult> DeleteToken(int id)
        {
            Token token = await db.Tokens.FindAsync(id);
            if (token == null)
            {
                return NotFound();
            }

            db.Tokens.Remove(token);
            await db.SaveChangesAsync();

            return Ok(token);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TokenExists(int id)
        {
            return db.Tokens.Count(e => e.Id == id) > 0;
        }
    }
}