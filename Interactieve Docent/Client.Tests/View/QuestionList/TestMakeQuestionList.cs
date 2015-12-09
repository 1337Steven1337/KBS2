using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Controller.QuestionList;
using Client.Tests.Factory;
using System.Collections.Generic;

namespace Client.Tests.View.QuestionList
{
    [TestClass]
    public class TestMakeQuestionList
    {
        [TestMethod]
        public void CreateNewList_ShouldHaveListCountOffFour()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            Dictionary<string, object> data = new Dictionary<string, object>();
            data["Name"] = "4";
            QuestionListController.SaveQuestionList(data);

            Assert.AreEqual(view.getCount(), 4);
        }
    }
}
