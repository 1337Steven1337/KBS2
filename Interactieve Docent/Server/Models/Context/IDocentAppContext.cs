using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models.Context
{
    public interface IDocentAppContext : IDisposable
    {
        DbSet<Server.Models.Question> Questions { get; set; }
        DbSet<Server.Models.QuestionList> QuestionLists { get; set; }
        DbSet<Server.Models.UserAnswer> UserAnswers { get; set; }
        DbSet<Server.Models.PredefinedAnswer> PredefinedAnswers { get; set; }
        DbSet<Server.Models.Account> Accounts { get; set; }
        DbSet<Server.Models.Pincode> Pincodes { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync();

        void MarkAsModified(Question item);
        void MarkAsModified(QuestionList item);
        void MarkAsModified(UserAnswer item);
        void MarkAsModified(PredefinedAnswer item);
        void MarkAsModified(Account item);
        void MarkAsModified(Pincode code);
    }
}
