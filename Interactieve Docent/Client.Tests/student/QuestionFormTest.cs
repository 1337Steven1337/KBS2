using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
namespace Client.Tests.student
{
    [TestClass]
    public class QuestionFormTest
    {
        Student.QuestionForm test = new Student.QuestionForm();

        [TestMethod]
        public void getProgressBarTest()
        {
        }
        [TestMethod]
        public void getQuestionListTest()
        {
            Assert.IsInstanceOfType(test.getQuestionList(), typeof(Model.QuestionList));
        }
        [TestMethod]
        public void isBusyTest()
        {
            bool expected = false;

            bool result = test.isBusy();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void getCurrentQuestionTest()
        {

        }
        [TestMethod]
        public void goToNextQuestionTest()
        {

        }


    }
}
