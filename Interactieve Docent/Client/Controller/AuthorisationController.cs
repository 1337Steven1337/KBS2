using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;
using Client.View.Authorisation;

namespace Client.Controller
{
    class AuthorisationController : AbstractController<Model.Account>
    {
        private IView View;
        private AccountFactory Factory = new AccountFactory();

        public AuthorisationController(AuthorisationView view)
        {
            this.View = view;
        }

        public override IView GetView()
        {
            return this.View;
        }

        public override void SetBaseFactory(IFactory<Model.Account> baseFactory)
        {
            this.Factory.SetBaseFactory(baseFactory);
        }

        public void login(Model.Account ac)
        {
            //Factory.FindAll(null, ac); something, now next thing is sending stuff to server and getting reply
        }

        public override void SetView(IView view)
        {
            this.View = view;
            this.View.SetController(this);
        }
    }
}
