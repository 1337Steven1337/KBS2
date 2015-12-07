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
            this.SignalRClient = SignalRClient.GetInstance();

            //add events
            questionController.selectedIndexChanged += QuestionController_selectedIndexChanged;

            this.UserAnswerFactory.UserAnswerAdded += UserAnswerFactory_userAnswerAdded;

            view.Show();
        }

        //do this is a student has answered a question
        private void UserAnswerFactory_userAnswerAdded(UserAnswer answer)
        {
            if (this.Question.UserAnswers == null)
            {
                this.Question.UserAnswers = new List<UserAnswer>();
            }

            this.Question.UserAnswers.Add(answer);

            //update the diagram 
            this.View.getPanel().Invoke((Action)delegate () { Redraw(); });
        }
        #endregion

        #region Events
        private void QuestionController_selectedIndexChanged(Question question)
        {
            if (question != null)
            {
                Factory.FindById(question.Id, this.View.getPanel(), this.SetQuestion);
            }
        }
        
        private void SignalRClient_connectionStatusChanged(Microsoft.AspNet.SignalR.Client.StateChange message)
        {
            //check what the connection status is
            if (message.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
            {
                //if the status is connected subscribe to the list
                SignalRClient.Subscribe(Question.List_Id);
            }
            else if (message.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connecting)
            {
                //if the status is connecting, wait for the connection to change to connected
            }
            else
            {
                //if it is none of the above, allert the user
                MessageBox.Show("Helaas! Er is iets fout gegaan..");
            }
        }
        #endregion


        #region Methodes
        //if another question is selected
        public void SetQuestion(Question q)
        {
            this.Question = q;
            this.SignalRClient.Subscribe(q.List_Id);
            this.View.getPanel().Invoke((Action)delegate () { Redraw(); });
        }

        private void Redraw()
        {
            //redraw the diagram
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
