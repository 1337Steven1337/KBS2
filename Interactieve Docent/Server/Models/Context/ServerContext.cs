using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Server.Models.Context
{
    public class ServerContext : DbContext, IDocentAppContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ServerContext() : base("name=ServerContext")
        {

        }

        public DbSet<Server.Models.Question> Questions { get; set; }
        public DbSet<Server.Models.OpenQuestion> OpenQuestions { get; set; }
        public DbSet<Server.Models.QuestionList> QuestionLists { get; set; }
        public DbSet<Server.Models.UserAnswer> UserAnswers { get; set; }
        public DbSet<Server.Models.UserAnswerToOpenQuestion> UserAnswerToOpenQuestions { get; set; }
        public DbSet<Server.Models.PredefinedAnswer> PredefinedAnswers { get; set; }
        public DbSet<Server.Models.Account> Accounts { get; set; }
        public DbSet<Server.Models.Token> Tokens { get; set; }
        public DbSet<Server.Models.Pincode> Pincodes { get; set; }

        public void MarkAsModified(Question item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModified(OpenQuestion item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModified(QuestionList item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModified(UserAnswer item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModified(UserAnswerToOpenQuestion item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModified(PredefinedAnswer item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public void MarkAsModified(Account item)
        {
            Entry(item).State = EntityState.Modified;
        }
        public void MarkAsModified(Token item)
        {
            Entry(item).State = EntityState.Modified;
        }
        public void MarkAsModified(Pincode item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
