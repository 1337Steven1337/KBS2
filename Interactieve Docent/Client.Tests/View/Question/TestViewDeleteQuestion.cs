using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Client.Tests.View.Question
{
    [TestClass]
    public class TestViewDeleteQuestion
    {
        [TestMethod]
        public void DeleteQuestionUserQuitsDialog_ShouldReturnValidFalse()
        {
            ViewDeleteQuestion view = new ViewDeleteQuestion();
            Boolean expected = false;

            Boolean result = view.valid;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DeleteQuestionUserConfirmsPositive_ShouldReturnValidTrue()
        {
            ViewDeleteQuestion view = new ViewDeleteQuestion();
            view.buttonOk_Click();
            Boolean expected = true;

            Boolean result = view.valid;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DeleteQuestionUserConfirmsNegative_ShouldReturnValidFalse()
        {
            ViewDeleteQuestion view = new ViewDeleteQuestion();
            view.buttonCancel_Click();
            Boolean expected = false;

            Boolean result = view.valid;

            Assert.AreEqual(expected, result);
        }
    }
}
