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
        public void TestShouldUpdateQuestion()
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
            dataNew["List_Id"] = list.Id;
            dataNew["Id"] = 1;

            controller.DeletePredefinedAnswers(answersNew, new Model.Question(dataNew));

            Dictionary<string, object> dataNew2 = new Dictionary<string, object>();
            dataNew2 = dataNew;
            dataNew2.Remove("List_Id");

            controller.UpdateQuestion(dataNew2);

            Assert.AreEqual(true, view.Compare(new Model.Question(dataNew2)));
        }
    }
}
