using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;
using Client.View.Question;

namespace Client.Controller.Question
{
    public class AddQuestionController : IController
    {
        private IAddQuestionView<Model.Question> view;

        public IView GetView()
        {
            return this.view;
        }

        public void SetBaseFactory(IFactory<Model.Question> factory)
        {
            throw new NotImplementedException();
        }

        public void SetView(IView view)
        {
            this.view = (IAddQuestionView<Model.Question>)view;
        }
    }
}
