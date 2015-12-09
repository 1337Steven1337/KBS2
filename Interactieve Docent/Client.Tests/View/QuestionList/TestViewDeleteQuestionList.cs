using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Tests.View.Question;

namespace Client.Tests.View.QuestionList
{
    [TestClass]
    public class TestViewDeleteQuestionList
    {
        [TestMethod]
        public void DeleteQuestionListUserQuitsDialog_ShouldReturnValidFalse()
        {
            ViewDeleteQuestionList view = new ViewDeleteQuestionList();
            Boolean expected = false;

            Boolean result = view.valid;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DeleteQuestionListUserConfirmsPositive_ShouldReturnValidTrue()
        {
            ViewDeleteQuestionList view = new ViewDeleteQuestionList();
            Boolean expected = false;
            Boolean result = view.valid;

            view.buttonOk_Click();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DeleteQuestionListUserConfirmsNegative_ShouldReturnValidFalse()
        {
            ViewDeleteQuestionList view = new ViewDeleteQuestionList();
            Boolean expected = false;
            Boolean result = view.valid;

            view.buttonCancel_Click();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DeleteQuestionListCreateView_ShouldReturnQuestionListName()
        {
            ViewDeleteQuestionList view = new ViewDeleteQuestionList();
            string expected = "TestName";

            view.setText("TestName");
            string result = view.Text;

            Assert.AreEqual(expected, result);
        }
    }
}
