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
    public class DiagramTest
    {
        private Model.Question Question;
        private PredefinedAnswer answer1, answer2, answer3;

        [TestMethod]
        public void ShouldReturnTheSameNumber()
        {
            Question = new Model.Question();
            Question.PredefinedAnswers = new List<PredefinedAnswer>();
            answer1 = new PredefinedAnswer();
            answer2 = new PredefinedAnswer();
            answer3 = new PredefinedAnswer();
            answer1.Id = 1;
            answer1.Text = "Ja";
            answer2.Id = 2;
            answer2.Text = "Ja";
            answer3.Id = 3;
            answer3.Text = "Nee";
            Question.PredefinedAnswers.Add(answer1);
            Question.PredefinedAnswers.Add(answer2);
            Question.PredefinedAnswers.Add(answer3);

            foreach (PredefinedAnswer item in Question.PredefinedAnswers)
            {
                Question.PredefinedAnswerCount++;
            }

            Assert.AreEqual(Question.PredefinedAnswerCount, 3);
            
        }
        
    }
}
