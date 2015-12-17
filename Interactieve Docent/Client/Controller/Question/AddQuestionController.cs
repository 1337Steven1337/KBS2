using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;
using Client.View.Question;
using System.Net;
using RestSharp;
using Client.View.Dialogs;

namespace Client.Controller.Question
{
    public class AddQuestionController : AbstractController<Model.Question>
    {
        #region Delegates
        public delegate void QuestionAddedDelegate(Model.Question question);
        public delegate void RemoveAddQuestionPanelDelegate(bool resizeTable);
        #endregion

        #region Events
        public event QuestionAddedDelegate QuestionAdded;
        public event RemoveAddQuestionPanelDelegate RemoveAddQuestionPanel;
        #endregion

        #region Properties
        private IAddView<Model.Question> View;
        private Model.QuestionList Parent { get; set; }
        private Model.Question CurrentQuestion;
        private QuestionFactory Factory = new QuestionFactory();
        private Dictionary<string, int> AnswersSaved = new Dictionary<string, int>();
        private Dictionary<string, int> AnswersDeleted = new Dictionary<string, int>();

        #endregion

        #region Constructors
        public override IView GetView()
        {
            return this.View;
        }
        #endregion

        #region Methods
        private void CallbackSaveQuestion(Model.Question question, HttpStatusCode status)
        {
            if (status == HttpStatusCode.Created && question != null)
            {
                if (this.QuestionAdded != null)
                {
                    QuestionAdded(question);
                }
            }
            this.View.ShowSaveResult(question, status);
        }

        private void CallbackUpdateQuestion(Model.Question question, HttpStatusCode status)
        {
            if (status == HttpStatusCode.NoContent && question != null)
            {
                //this.View.ShowUpdateResult(question, status);
            }
        }

        public override void SetBaseFactory(IFactory<Model.Question> factory)
        {
            this.Factory.SetBaseFactory(factory);
        }

        public override void SetView(IView view)
        {
            this.View = (IAddView<Model.Question>)view;
            this.View.SetController(this);
        }

        public void UpdateQuestion(Dictionary<string, object> data)
        {
            data.Add("List_Id", this.Parent.Id);

            Model.Question question = new Model.Question(data);
            question.Id = Convert.ToInt32(data["Id"]);
            Factory.Update(question, this.View.GetHandler(), this.CallbackUpdateQuestion);
        }

        public void SaveQuestion(Dictionary<string, object> data)
        {
            data.Add("List_Id", this.Parent.Id);

            Model.Question question = new Model.Question(data);
            Factory.Save(question, this.View.GetHandler(), this.CallbackSaveQuestion);
        }

        public void DeletePredefinedAnswers(List<Model.PredefinedAnswer> answers, Model.Question question)
        {
            this.DeletePredefinedAnswers(answers, question, new BaseFactory<PredefinedAnswer>());
        }

        public void DeletePredefinedAnswers(List<Model.PredefinedAnswer> answers, Model.Question question, IFactory<Model.PredefinedAnswer> baseFactory)
        {
            this.AnswersSaved.Clear();
            this.CurrentQuestion = question;
            foreach (Model.PredefinedAnswer answer in answers)
            {
                this.AnswersDeleted.Add(answer.Text, 0);
            }

            PredefinedAnswerFactory factory = new PredefinedAnswerFactory();
            factory.SetBaseFactory(baseFactory);

            foreach (Model.PredefinedAnswer answer in answers)
            {
                factory.Delete(answer, this.View.GetHandler(), CallbackDeletePredefinedAnswers);
            }
        }

        private void CallbackDeletePredefinedAnswers(PredefinedAnswer predefinedAnswer, HttpStatusCode status)
        {
            if (status == HttpStatusCode.Created && predefinedAnswer != null)
            {

                AnswersDeleted[predefinedAnswer.Text] = 1;
            }
            else
            {
                AnswersDeleted[predefinedAnswer.Text] = 2;
            }

            if (!AnswersDeleted.ContainsValue(0))
            {
                if (AnswersDeleted.ContainsValue(2))
                {
                    //this.Factory.DeleteAsync(this.CurrentQuestion);
                    this.View.ShowSaveFailed();
                }
                else
                {
                    this.View.ShowSaveSucceed();
                    //this.View.SavePredefinedAnswers(predefinedAnswer, );
                }
            }
        }

        public void SavePredefinedAnswers(List<Model.PredefinedAnswer> answers, Model.Question question)
        {
            this.SavePredefinedAnswers(answers, question, new BaseFactory<PredefinedAnswer>());
        }

        public void SavePredefinedAnswers(List<Model.PredefinedAnswer> answers, Model.Question question, IFactory<Model.PredefinedAnswer> baseFactory)
        {
            this.AnswersSaved.Clear();
            this.CurrentQuestion = question;

            foreach (Model.PredefinedAnswer answer in answers)
            {
                this.AnswersSaved.Add(answer.Text, 0);
            }

            PredefinedAnswerFactory factory = new PredefinedAnswerFactory();
            factory.SetBaseFactory(baseFactory);

            foreach (Model.PredefinedAnswer answer in answers)
            {
                answer.Question_Id = question.Id;

                if (answer.Text == this.View.GetSelectedAnswer().Text)
                {
                    answer.RightAnswer = true;
                }
                else
                {
                    answer.RightAnswer = false;
                }

                factory.Save(answer, this.View.GetHandler(), CallbackSavePredefinedAnswers);
            }
        }

        private void CallbackSavePredefinedAnswers(PredefinedAnswer predefinedAnswer, HttpStatusCode status)
        {
            if (status == HttpStatusCode.Created && predefinedAnswer != null)
            {
                AnswersSaved[predefinedAnswer.Text] = 1;
            }
            else
            {
                AnswersSaved[predefinedAnswer.Text] = 2;
            }

            if (!AnswersSaved.ContainsValue(0))
            {
                if (AnswersSaved.ContainsValue(2))
                {
                    //this.Factory.DeleteAsync(this.CurrentQuestion);
                    this.View.ShowSaveFailed();
                }
                else
                {
                    this.View.ShowSaveSucceed();
                }
            }
        }

        public void SetQuestionList(Model.QuestionList list)
        {
            this.Parent = list;
        }

        public void InvokeRemoveQuestionPanel()
        {
            if (this.RemoveAddQuestionPanel != null)
            {
                this.RemoveAddQuestionPanel(true);
            }
        }
        #endregion
    }
}
