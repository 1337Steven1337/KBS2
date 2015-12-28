using Client.View;
using System;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using System.Net;
using System.Collections.Generic;

namespace Client.Tests.View.Question
{
    public partial class ViewDeleteQuestionList : IListView<Model.QuestionList>
    {
        public List<Model.QuestionList> QuestionList = new List<Model.QuestionList>();

        public Boolean valid { get; set; }
        public string Text { private set; get; }

        public ViewDeleteQuestionList()
        {
            valid = false;
        }

        public void buttonOk_Click()
        {
            valid = true;
        }

        public void buttonCancel_Click()
        {
        }

        public void setText(string text)
        {
            Text = text;
        }

        public void ShowSaveQuestionListResult(Model.QuestionList instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteQuestionListResult(Model.QuestionList instance, HttpStatusCode status)
        {
            if (status == HttpStatusCode.OK && instance != null)
            {
                DeleteItem(instance);
            }
        }

        public void FillList(List<Model.QuestionList> list)
        {
            throw new NotImplementedException();
        }

        public void AddItem(Model.QuestionList item)
        {
            QuestionList.Add(item);
        }

        public void DeleteItem(Model.QuestionList item)
        {
            QuestionList.Remove(item);
        }

        public IControlHandler GetHandler()
        {
            return new TestControlHandler();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteQuestionResult(Model.QuestionList instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Model.QuestionList item)
        {
            throw new NotImplementedException();
        }

        public Model.Question getSelectedItem()
        {
            throw new NotImplementedException();
        }
    }
}
