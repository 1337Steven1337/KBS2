using Client.Model;
using System;
using System.Data.Entity;

namespace Client
{
    public interface IContext : IDisposable
    {
        DbSet<Question> Questions { get; }
        int SaveChanges();
        void MarkAsModified(Question item);
    }
}
