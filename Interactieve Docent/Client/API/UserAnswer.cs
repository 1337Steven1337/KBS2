using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Client.API
{
    class UserAnswer : Entity
    {
        public int Id { get; private set; }


        public static UserAnswer getById(int id)
        {
            return UserAnswer.getById<UserAnswer>(id, "UserAnswers");
        }

        public static List<UserAnswer> getAll()
        {
            return UserAnswer.getAll<UserAnswer>("UserAnswers");
        }

        protected override void fetch()
        {
            UserAnswer ua = UserAnswer.getById(this.Id);
            this.copyValues<UserAnswer>(this, ua);
            this._fetched = true;
        }
    }
}
