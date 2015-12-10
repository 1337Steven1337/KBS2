using Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using System.Net;

namespace Client.Tests.View.Question
{
    public class TestAddQuestionView : IAddView<Model.Question>
    {
        public List<Model.Question> AddQuestionList = new List<Model.Question>();

        public int CountAddQuestionList()
        {
            return AddQuestionList.Count;            
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new TestControlHandler();
        }

        public PredefinedAnswer GetSelectedAnswer()
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            //throw new NotImplementedException();
        }

        public void ShowSaveFailed()
        {
            throw new NotImplementedException();
        }

        public void ShowSaveResult(Model.Question instance, HttpStatusCode status)
        {
            if(status == HttpStatusCode.Created)
            {
                AddQuestionList.Add(instance);
            }
        }

        public void ShowSaveSucceed()
        {
            throw new NotImplementedException();
        }
    }
}
