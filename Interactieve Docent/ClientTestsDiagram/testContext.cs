using System;
using System.Data.Entity;
using Client.API.Models;

namespace ClientTestsDiagram
{
    class TestContext : Client.IContext
    {
        public TestContext()
        {
            this.Questions = new TestQuestionDbSet();
        }

        public DbSet<Question> Questions { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(Question item) { }
        public void Dispose() { }
    }
}
