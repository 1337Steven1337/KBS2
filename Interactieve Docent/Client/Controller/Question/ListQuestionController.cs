using Client.Factory;
using Client.View;
using Client.View.Question;
using System.Collections.Generic;
using System.Net;

namespace Client.Controller.Question
{
    public class ListQuestionController : AbstractController<Model.Question>
    {
        #region Instances
        private IListView<Model.Question> View { get; set; }
        private QuestionFactory Factory = new QuestionFactory();
        public Model.QuestionList CurrentList { get; private set; }
        #endregion

        #region Constructors
        public ListQuestionController(IView view)
        {
            this.SetView(view);
            this.View.SetController(this);
        }
        #endregion

        #region Event
        public void QuestionAdded(Model.Question question)
        {
            this.LoadList(CurrentList);

            //questions dont get predefinedanswers, so when update the object is not filled with predefinedanswers.
            //this.View.AddItem(question);
        }

        public void QuestionUpdated(Model.Question question)
        {
            //Load questions again from server..
            this.LoadList(CurrentList);

            //!!! better solution would be.. reset the question with the updated question. 
            //var index = CurrentList.Questions.FindIndex(x => x.Id == question.Id);
            //CurrentList.Questions.RemoveAt(index);
            //CurrentList.Questions.Insert(index, question);
        }
        #endregion

        #region Methods

        private void FillList(List<Model.Question> questions, HttpStatusCode status)
        {
            if(status == HttpStatusCode.OK && questions != null)
            {
                this.View.FillList(questions.FindAll(x => x.List_Id == this.CurrentList.Id));
            }
        }

        public void LoadList(Model.QuestionList list)
        {
            this.CurrentList = list;
            this.Factory.FindAll(this.View.GetHandler(), this.FillList);
        }
        #endregion

        #region Overrides
        public override IView GetView()
        {
            return this.View;
        }

        public override void SetView(IView view)
        {
            this.View = (IListView<Model.Question>)view;
        }

        public override void SetBaseFactory(IFactory<Model.Question> baseFactory)
        {
            this.Factory.SetBaseFactory(baseFactory);
        }
        //Give status 
        public void CallbackDeleteQuestion(Model.Question question, HttpStatusCode status)
        {
            this.View.ShowDeleteQuestionResult(question, status);
        }

        //delete the question
        public void DeleteQuestion(Model.Question question)
        {
            this.Factory.Delete(question, this.View.GetHandler(), CallbackDeleteQuestion);
        }
        #endregion
    }
}
