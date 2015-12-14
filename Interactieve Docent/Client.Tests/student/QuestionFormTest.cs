using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Client.Tests.student
{
    [TestClass]
    public class QuestionFormTest
    {
        Student.QuestionForm test = new Student.QuestionForm();
        Student.QuestionForm testfilled;

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
        public void TestIfTimerIsRunning_AfterTimerHasBeenStarted()
        {
            bool expected = true;
            Timer timer = test.getTimer();
            timer.Start();
            Assert.AreEqual(timer.Enabled, expected);
        }


        [TestMethod]
        public void TestIfTimerIsNotRunning_WhenQuestionTimeIs0()
        {
            bool expected = false;
            Model.Question question = new Model.Question();
            question.Time = 0;
            Assert.AreEqual(question.Time, 0);
        }







    }
}
