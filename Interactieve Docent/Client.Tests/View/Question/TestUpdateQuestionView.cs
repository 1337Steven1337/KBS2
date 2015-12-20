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
    public class TestUpdateQuestionView : IAddView<Model.Question>
    {    
        public Boolean questionIsUpdated = false;

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
            throw new NotImplementedException();
        }

        public void ShowSaveSucceed()
        {
            throw new NotImplementedException();
        }

        public void ShowUpdateResult(Model.Question instance, HttpStatusCode status)
        {
            if (status == HttpStatusCode.NoContent && instance != null)
            {
                this.questionIsUpdated = true;
            }
        }

        public void ShowDeleteAnswersResult(Model.Question instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ClearAllFields()
        {
            throw new NotImplementedException();
        }
    }
}
