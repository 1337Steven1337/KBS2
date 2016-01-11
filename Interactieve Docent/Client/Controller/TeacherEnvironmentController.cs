using Client.View.Diagram;
using Client.View.Teacher;
using System.Windows.Forms;
using Client.Model;
using System.Collections.Generic;
using System.Linq;
using Client.Factory;
using System;
using Client.Service.SignalR;
using Client.Service.Thread;
using Client.View;
using System.ComponentModel;
using System.Net;

namespace Client.Controller
{

    class TeacherEnvironmentController : AbstractController<Model.Question>
    {

        private TeacherEnvironmentView View;
        private SignalRClient SignalRClient;
        private QuestionFactory Factory = new QuestionFactory();
        public Model.QuestionList CurrentList;

        
        public TeacherEnvironmentController(TeacherEnvironmentView view, Model.QuestionList QuestionList)
        {
            this.View = view;
            this.View.SetController(this);
            this.SignalRClient = SignalRClient.GetInstance();
            this.CurrentList = QuestionList;
            this.LoadList(QuestionList);
        }

        private void FillList(List<Model.Question> questions, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK && questions != null)
            {
                this.View.FillList(questions.FindAll(x => x.List_Id == this.CurrentList.Id));
            }
        }

        public void LoadList(Model.QuestionList list)
        {
            this.CurrentList = list;
            this.Factory.FindAll(this.View.GetHandler(), this.FillList);
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