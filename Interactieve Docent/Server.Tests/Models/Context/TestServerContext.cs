using Server.Models;
using Server.Models.Context;
using Server.Tests.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Tests.Models.Context
{
    public class TestServerContext : IDocentAppContext
    {
        public TestServerContext()
        {
            this.Questions = new TestQuestionDbSet();
            this.UserAnswers = new TestUserAnswerDbSet();
            this.QuestionLists = new TestListDbSet();
            this.PredefinedAnswers = new TestPredefinedAnswerDbSet();
        }

        public DbSet<Server.Models.Question> Questions { get; set; }
        public DbSet<Server.Models.QuestionList> QuestionLists { get; set; }
        public DbSet<Server.Models.UserAnswer> UserAnswers { get; set; }
        public DbSet<Server.Models.PredefinedAnswer> PredefinedAnswers { get; set; }

        public void MarkAsModified(Question item) { }
        public void MarkAsModified(QuestionList item) { }
        public void MarkAsModified(UserAnswer item) { }
        public void MarkAsModified(PredefinedAnswer item) { }

        public int SaveChanges()
        {
            return 0;
        }

        public virtual Task<int> SaveChangesAsync()
        {
            Task<int> task = new Task<int>(new Func<int>(SaveChanges));
            task.Start();

            return task;
        }

        public void Dispose() { }
    }
}
