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

namespace Client.Controller.Question
{
    public class AddQuestionController : AbstractController<Model.Question>
    {
        public delegate void QuestionAddedDelegate(Model.Question question);

        public event QuestionAddedDelegate QuestionAdded;

        private IAddView<Model.Question> View;
        private QuestionFactory Factory = new QuestionFactory();
        private Model.QuestionList Parent { get; set; }

        public override IView GetView()
        {
            return this.View;
        }

        private void CallbackSaveQuestion(Model.Question question, HttpStatusCode status)
        {
            if(status == HttpStatusCode.Created && question != null)
            {
                if(this.QuestionAdded != null)
                {
                    QuestionAdded(question);
                }
            }

            this.View.ShowSaveResult(question, status);
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

        public void SaveQuestion(Dictionary<string, object> data)
        {
            data.Add("List_Id", this.Parent.Id);

            Model.Question question = new Model.Question(data);
            Factory.Save(question, this.View.GetHandler(), this.CallbackSaveQuestion);
        }

        public void SetQuestionList(Model.QuestionList list)
        {
            this.Parent = list;
        }
    }
}
