using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;
using Client.View.Authorisation;
using Client.Service.Login;

namespace Client.Controller
{
    class AuthorisationController : AbstractController<Model.Account>
    {
        private IView View;
        private LoginClient loginClient = new LoginClient();

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
            throw new NotImplementedException();
        }

        public void login(Model.Account ac)
        {
            //loginClient.sendshittodatabase(ac);
        }

        public override void SetView(IView view)
        {
            this.View = view;
            this.View.SetController(this);
        }
    }
}
