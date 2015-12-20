using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Controller.Question;
using Client.Tests.View.Question;
using Client.Tests.Factory;
using System.Collections.Generic;

namespace Client.Tests.Controllers
{
    [TestClass]
    public class TestUpdateQuestion
    {
        [TestMethod]
        public void TestUpdateQuestion_ShouldReturnTrue()
        {
            TestUpdateQuestionView view = new TestUpdateQuestionView();

            AddQuestionController controller = new AddQuestionController();
            controller.SetBaseFactory(new TestQuestionFactory());
            controller.SetView(view);

            Model.QuestionList list = new Model.QuestionList();
            list.Id = 1;
            controller.SetQuestionList(list);

            List<Model.PredefinedAnswer> answersNew = new List<Model.PredefinedAnswer>() { new Model.PredefinedAnswer() { Text = "test2" } };
            Dictionary<string, object> dataNew = new Dictionary<string, object>();
            dataNew["Points"] = 2;
            dataNew["Time"] = 2;
            dataNew["Text"] = "test2";
            dataNew["PredefinedAnswerCount"] = answersNew.Count;
            dataNew["Id"] = 1;

            controller.UpdateQuestion(dataNew);

            Assert.AreEqual(true, view.questionIsUpdated);
        }

    }
}
