using Client.View.Diagram;
using Client.View.Docent;
using System.Windows.Forms;
using Client.Model;
using System.Collections.Generic;
using System.Linq;
using Client.Factory;
using System;
using Client.Service.SignalR;
using Client.Service.Thread;
using Client.View;

namespace Client.Controller
{

    class DocentOmgevingController : AbstractController<Model.Question>
    {

        private DocentOmgevingView View;
        private Model.Question Question;

        //Test list
        public Model.QuestionList QuestionList { get; private set; }
       
        private SignalRClient SignalRClient;

        public DocentOmgevingController(DocentOmgevingView view)
        {
            this.View = view;
            this.View.SetController(this);
            this.SignalRClient = SignalRClient.GetInstance();

            //Test list
            QuestionList = new Model.QuestionList();

            view.Show();
        }

        public override IView GetView()
        {
            throw new NotImplementedException();
        }

        public override void SetBaseFactory(IFactory<Model.Question> baseFactory)
        {
            throw new NotImplementedException();
        }

        public override void SetView(IView view)
        {
            throw new NotImplementedException();
        }
    }
}