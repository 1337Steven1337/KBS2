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
using System.ComponentModel;
using System.Net;

namespace Client.Controller
{

    class DocentOmgevingController : AbstractController<Model.Question>
    {

        private DocentOmgevingView View;
        private SignalRClient SignalRClient;
        private QuestionFactory Factory = new QuestionFactory();
        public Model.QuestionList CurrentList;
        public Model.Question CurrentQuestion;

        public List<int> Votes;
        public List<string> Questions;

        public DocentOmgevingController(DocentOmgevingView view, Model.QuestionList QuestionList)
        {
            this.View = view;
            this.View.SetController(this);
            this.SignalRClient = SignalRClient.GetInstance();
            this.LoadList(QuestionList);
            this.CurrentQuestion = View.GetCurrentQuestion();
            this.FillDiagram(CurrentQuestion);
            view.Show();


        }
        private void FillDiagram(Model.Question CurrentQuestion)
        {
            Dictionary<string, int> questionVotes = new Dictionary<string, int>();

            //if the predefinedanswer is empty zet votes to zero
          /*  foreach (PredefinedAnswer preAnswer in CurrentQuestion.PredefinedAnswers)
            {
                questionVotes[preAnswer.Text] = 0;
            }
            
            //for every given answer were the userAnswer_Id is equal to a PredefinedAnswer_Id add one to votes
            foreach (UserAnswer answer in CurrentQuestion.UserAnswers)
            {
                string text = CurrentQuestion.PredefinedAnswers.Find(x => x.Id == answer.PredefinedAnswer_Id).Text;
                questionVotes[text] += 1;
            }
         */
          //  Votes = questionVotes.Values.ToList<int>();
          //  Questions = questionVotes.Keys.ToList<string>();
             Votes = new List<int> { 1, 2, 3 };
             Questions = new List<string> { "a" , "b" , "c" };

                this.View.Make(Votes, Questions);
            
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