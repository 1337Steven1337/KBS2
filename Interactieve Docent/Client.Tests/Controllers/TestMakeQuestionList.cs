using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Controller.QuestionList;
using Client.Tests.Factory;
using System.Collections.Generic;
using Client.Tests.View.QuestionList;

namespace Client.Tests.Controllers
{
    [TestClass]
    public class TestMakeQuestionList
    {
        [TestMethod]
        public void CreateNewList_ShouldHaveListCountOffFour()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            TestViewAddQuestionList dlg = new TestViewAddQuestionList();

            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();


            dlg.SetText("4");
            dlg.Ok();
            Dictionary<string, object> data = new Dictionary<string, object>();
            if (dlg.valid)
            {
                data["Name"] = dlg.text;
                QuestionListController.SaveQuestionList(data);
            }

            Assert.AreEqual(view.getCount(), 4);
        }

        [TestMethod]
        public void CreateNewListWithNameEmpty_ShouldHaveListCountOffThree()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            TestViewAddQuestionList dlg = new TestViewAddQuestionList();
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();
            
            dlg.Ok();
            Dictionary<string, object> data = new Dictionary<string, object>();
            if (dlg.valid)
            {
                data["Name"] = dlg.text;
                QuestionListController.SaveQuestionList(data);
            }

            Assert.AreEqual(3, view.getCount());
        }

        [TestMethod]
        public void CreateNewListWhenNotConfirmed_ShouldHaveListCountOffThree()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            TestViewAddQuestionList dlg = new TestViewAddQuestionList();
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            dlg.SetText("List");
            Dictionary<string, object> data = new Dictionary<string, object>();
            if (dlg.valid)
            {
                data["Name"] = dlg.text;
                QuestionListController.SaveQuestionList(data);
            }

            Assert.AreEqual(3, view.getCount());
        }
    }
}
