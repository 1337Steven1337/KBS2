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
using RestSharp;
using System.Net;

namespace Client.Controller
{
    public class AuthorisationController : AbstractController<Model.Account>
    {
        private IAuthorisationView View; 
        private LoginClient loginClient = LoginClient.GetInstance();
        private AccountFactory Factory = new AccountFactory();

        public AuthorisationController(IAuthorisationView view)
        {
            this.View = view;
            this.View.SetController(this);
        }

        public override void SetBaseFactory(IFactory<Model.Account> baseFactory)
        {
            throw new NotImplementedException();
        }

        public void CheckAuthorisationResult(Model.Account acccount)
        {
            this.Factory.FindByIdAsync(acccount.Id, this.View.ShowAuthorisationResult);
            //loginClient.sendshittodatabase(ac);
        }

        public override IView GetView() 
        {
            return this.View;
        }

        public override void SetView(IView view)
        {
            this.View = (IAuthorisationView)view;
        }
    }
}
