using Client.View.Diagram;
using System.Windows.Forms;
using Client.Model;
using System.Collections.Generic;
using System.Linq;
using Client.Factory;
using System;

namespace Client.Controller
{
    public class DiagramController
    {
        #region Variables & Instances
        public List<string> questions;
        public List<int> votes;

        private Dictionary<string, int> questionVotes = new Dictionary<string, int>();

        private IDiagramView view;

        private Panel panel;

        private Question Question;

        private QuestionFactory factory = new QuestionFactory();
        #endregion

        #region Constructor
        public DiagramController(IDiagramView view, QuestionController questionController)
        {
            this.view = view;
            this.view.setController(this);

            questionController.selectedIndexChanged += QuestionController_selectedIndexChanged;

            view.Show();
        }

        private void QuestionController_selectedIndexChanged(Event.QuestionControllerSelectedIndexChanged message)
        {
            factory.findById(message.question.Id, this.SetQuestion);
        }
        #endregion

        #region Methodes

        public void SetQuestion(Question q)
        {
            this.view.getPanel().Invoke((Action)delegate ()
            {
                this.Question = q;

                if (this.Question.PredefinedAnswers != null && this.Question.UserAnswers != null)
                {
                    this.GetData();
                    this.view.Make(this.votes, this.questions, this.Question.Text);
                }
            });
        }

        private void GetData()
        {
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

            votes = questionVotes.Values.ToList<int>();
            questions = questionVotes.Keys.ToList<string>();
        }
        #endregion
    }
}
