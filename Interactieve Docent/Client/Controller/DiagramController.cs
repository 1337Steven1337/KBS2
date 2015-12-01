using Client.View.Diagram;
using System.Windows.Forms;
using Client.Model;
using System.Collections.Generic;
using System.Linq;
using Client.Factory;
using System;
using Client.Service.SignalR;

namespace Client.Controller
{
    public class DiagramController
    {
        #region Variables & Instances
        public List<string> Questions;
        public List<int> Votes;

        private IDiagramView View;

        private Question Question;

        private QuestionFactory Factory = new QuestionFactory();
        private UserAnswerFactory UserAnswerFactory = new UserAnswerFactory();

        private SignalRClient SignalRClient;
        #endregion

        #region Constructor
        public DiagramController(IDiagramView view, QuestionController questionController)
        {
            this.View = view;
            this.View.setController(this);
            this.SignalRClient = SignalRClient.getInstance();

            questionController.selectedIndexChanged += QuestionController_selectedIndexChanged;

            this.UserAnswerFactory.userAnswerAdded += UserAnswerFactory_userAnswerAdded;

            view.Show();
        }

        private void UserAnswerFactory_userAnswerAdded(UserAnswer answer)
        {
            if (this.Question.UserAnswers == null)
            {
                this.Question.UserAnswers = new List<UserAnswer>();
            }

            this.Question.UserAnswers.Add(answer);

            this.View.getPanel().Invoke((Action)delegate () { Redraw(); });
        }
        #endregion

        #region Events
        private void QuestionController_selectedIndexChanged(Event.QuestionControllerSelectedIndexChanged message)
        {
             Factory.findById(message.question.Id, this.View.getPanel(), this.SetQuestion);
        }
        
        private void SignalRClient_connectionStatusChanged(Microsoft.AspNet.SignalR.Client.StateChange message)
        {
            if (message.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
            {
                SignalRClient.subscribe(Question.List_Id);
            }
            else if (message.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connecting)
            {

            }
            else
            {
                MessageBox.Show("Helaas! Er is iets fout gegaan..");
            }
        }

        private void SignalR_subscriptionStatusChanged(API.EventArgs.SubscriptionStatus message)
        {

        }
        #endregion


        #region Methodes
        public void SetQuestion(Question q)
        {
            this.Question = q;
            this.SignalRClient.subscribe(q.List_Id);
            this.View.getPanel().Invoke((Action)delegate () { Redraw(); });
        }

        private void Redraw()
        {
            if (this.Question.PredefinedAnswers != null && this.Question.UserAnswers != null)
            {
                this.GetData();
                this.View.Make(this.Votes, this.Questions, this.Question.Text);
            }
        }

        private void GetData()
        {
             Dictionary<string, int> questionVotes = new Dictionary<string, int>();

            //if the predefinedanswer is empty zet votes to zero
            foreach (PredefinedAnswer preAnswer in Question.PredefinedAnswers)
            {
                questionVotes[preAnswer.Text] = 0;
            }

            //for every given answer were the userAnswer_Id is equal to a PredefinedAnswer_Id add one to votes
            foreach (UserAnswer answer in Question.UserAnswers)
            {
                string text = Question.PredefinedAnswers.Find(x => x.Id == answer.PredefinedAnswer_Id).Text;
                questionVotes[text] += 1;
            }
            
            Votes = questionVotes.Values.ToList<int>();
            Questions = questionVotes.Keys.ToList<string>();
        }
        #endregion
    }
}
