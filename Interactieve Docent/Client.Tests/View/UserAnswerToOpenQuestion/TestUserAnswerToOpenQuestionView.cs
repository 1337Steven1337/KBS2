using System;
using System.Collections.Generic;
using System.Net;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.View;
using System.Windows.Forms;

namespace Client.Tests.View.UserAnswerToOpenQuestion
{
    public class TestUserAnswerToOpenQuestionView : IResultView<Model.UserAnswerToOpenQuestion>
    {
        private int Count;
        private UserAnswerToOpenQuestionController Controller;

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void FillList(List<Model.UserAnswerToOpenQuestion> list)
        {
            this.Count = list.Count;
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(new Control());
        }

        public int getCount()
        {
            return Count;
        }

        public void Refresh(List<Model.UserAnswerToOpenQuestion> answers, OpenQuestion question)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this.Controller = (UserAnswerToOpenQuestionController)controller;
        }

        public void setText(string text)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            //q
        }

        public void AddItem(Model.UserAnswerToOpenQuestion ua)
        {
            //Controller;
        }
    }
}
