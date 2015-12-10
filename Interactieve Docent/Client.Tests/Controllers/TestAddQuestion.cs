using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Controller.Question;
using Client.Tests.View.Question;
using Client.Tests.Factory;
using System.Collections.Generic;

namespace Client.Tests.Controllers
{
    [TestClass]
    public class TestAddQuestion
    {
        [TestMethod]
        public void TestSaveQuestion_shouldAddQuestionToList()
        {
            TestAddQuestionView view = new TestAddQuestionView();
            AddQuestionController controller = new AddQuestionController();
            controller.SetBaseFactory(new TestQuestionFactory());
            controller.SetView(view);

            Model.QuestionList list = new Model.QuestionList();
            list.Id = 1;
            controller.SetQuestionList(list);

            Dictionary<string, object> data = new Dictionary<string, object>();
            data["Points"] = 2;
            data["Time"] = 5;
            data["Text"] = "Test Vraag";
            data["PredefinedAnswerCount"] = 0;
            controller.SaveQuestion(data);

            Assert.AreEqual(view.CountAddQuestionList(), 1);
        }
    }
}
