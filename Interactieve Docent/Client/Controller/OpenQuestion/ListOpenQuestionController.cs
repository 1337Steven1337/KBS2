using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;
using System.Net;

namespace Client.Controller.OpenQuestion
{
    class ListOpenQuestionController : AbstractController<Model.OpenQuestion>
    {
        #region Instances
        private IResultView<Model.OpenQuestion> View { get; set; }
        private OpenQuestionFactory Factory = new OpenQuestionFactory();
        #endregion

        #region Constructors
        public ListOpenQuestionController(IView view)
        {
            this.SetView(view);
            this.View.SetController(this);
            this.LoadList();
        }
        #endregion

        #region Event
        public void QuestionAdded(Model.OpenQuestion openQuestion)
        {
            this.View.AddItem(openQuestion);
        }
        #endregion

        #region Methods
        private void FillList(List<Model.OpenQuestion> openQuestions, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK && openQuestions != null)
            {
                this.View.FillList(openQuestions);
            }
        }

        public void LoadList()
        {
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
            this.View = (IResultView<Model.OpenQuestion>)view;
        }

        public void SetBaseFactory(IFactory<Model.Question> baseFactory)
        {
            throw new NotImplementedException();
        }

        public override void SetBaseFactory(IFactory<Model.OpenQuestion> baseFactory)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
