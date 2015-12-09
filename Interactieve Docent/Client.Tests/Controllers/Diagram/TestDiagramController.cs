using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Model;
using Client.Factory;
using Client.Service.Thread;
using Client.View.Diagram;
using Client.Controller.Question;
using Client.Tests.View.Question;
using Client.Tests.Factory;
using System.Collections.Generic;
using System.Diagnostics;

namespace Client.Tests.View.Diagram
{
    [TestClass]
    public class TestDiagramController
    {
        private Model.Question Question;
        private PredefinedAnswer pre1, pre2;
        private UserAnswer answer1, answer2, answer3;
        private AddQuestionController controller;

        [TestMethod]
        public void ShouldReturnTheSameNumber()
        {
            TestQuestionFactory factory = new TestQuestionFactory();
            Question = new Model.Question();
            Question.PredefinedAnswers = new List<PredefinedAnswer>();
            pre1 = new PredefinedAnswer();
            pre2 = new PredefinedAnswer();
            pre1.Id = 1;
            pre1.Text = "Ja";
            pre2.Id = 2;
            pre2.Text = "Nee";
            Question.PredefinedAnswers.Add(pre1);
            Question.PredefinedAnswers.Add(pre2);

            answer1 = new UserAnswer();
            answer2 = new UserAnswer();
            answer3 = new UserAnswer();
            answer1.PredefinedAnswer_Id = pre1.Id;
            answer2.PredefinedAnswer_Id = pre2.Id;
            answer3.PredefinedAnswer_Id = pre1.Id;

            
            foreach (PredefinedAnswer item in Question.PredefinedAnswers)
            {
                Question.PredefinedAnswerCount++;
            }

            Assert.AreEqual(Question.PredefinedAnswerCount, 3);
            
        }
        
    }
}
