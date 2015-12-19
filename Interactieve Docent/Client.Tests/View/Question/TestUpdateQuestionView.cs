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
        public List<Model.PredefinedAnswer> DeleteAnswersList = new List<Model.PredefinedAnswer>();
        public Model.Question oldQuestion;

        public TestUpdateQuestionView()
        {
            List<Model.PredefinedAnswer> answersOld = new List<Model.PredefinedAnswer>() { new Model.PredefinedAnswer() { Text = "test1" } };
            Dictionary<string, object> dataOld = new Dictionary<string, object>();
            dataOld["Points"] = 1;
            dataOld["Time"] = 1;
            dataOld["Text"] = "test1";
            dataOld["PredefinedAnswerCount"] = answersOld.Count;
            dataOld["List_Id"] = 1;
            dataOld["Id"] = 1;

            this.oldQuestion = new Model.Question(dataOld);
        }

        public Boolean Compare(Model.Question newQuestion) {
            oldQuestion = newQuestion;

            if (oldQuestion == newQuestion)
            {
                return true;
            }
            else
            {
                return false;
            }                   
        }
        public int CountDeleteAnswersList()
        {
            return DeleteAnswersList.Count;            
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
            return new PredefinedAnswer() { Text = "test2" };
            //throw new NotImplementedException();
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
            if (status == HttpStatusCode.NoContent)
            {
                this.oldQuestion = instance;
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
