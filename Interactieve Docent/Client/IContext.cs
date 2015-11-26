using System;
using System.Data.Entity;
using Client.API.Models;

namespace Client
{
    public interface IContext : IDisposable
    {
        DbSet<Question> Questions { get; }
        int SaveChanges();
        void MarkAsModified(Question item);
    }
}
