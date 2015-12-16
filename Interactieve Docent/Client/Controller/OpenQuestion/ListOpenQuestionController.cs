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
        private IListView<Model.OpenQuestion> View { get; set; }
        private OpenQuestionFactory Factory = new OpenQuestionFactory();
        #endregion

        #region Constructors
        public ListOpenQuestionController(IView view)
        {
            this.SetView(view);
            this.View.SetController(this);
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

        public void LoadList(Model.QuestionList list)
        {
            throw new NotImplementedException();
        }
        #endregion

        public override IView GetView()
        {
            throw new NotImplementedException();
        }

        public override void SetBaseFactory(IFactory<Model.OpenQuestion> baseFactory)
        {
            throw new NotImplementedException();
        }

        public override void SetView(IView view)
        {
            throw new NotImplementedException();
        }
    }
}
