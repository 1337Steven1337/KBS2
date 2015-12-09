//using System;
//using System.Diagnostics;
//using System.Windows.Forms;
//using Client.API.Models;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Client.Student;

//namespace Client.Tests.Controllers
//{
//    [TestClass]
//    public class Questionstest
//    {

//        Questions questions = new Questions(69);
//        [TestMethod]
//        public void Questions_GoTONexquestion_ShouldGoToNextQuestion() 
//        {

//            //questions.goToNextQuestion();
//            Question testText = Question.getById(277);
//            Debug.WriteLine("Text in rij 277 = " + testText.Text);
//            Assert.AreEqual("Test1",questions.ToString());
//        }

//        [TestMethod]
//        public void Question_QuestionSaveHandler_ShouldSaveOneQuestion()
//        {
//            int beforSave = UserAnswer.getAll().Count;
//            Button btn = new Button();
//            btn.ImageIndex = 10;
//            //questions.currentQuestion.Id = 69;
//            //questions.AnswerSaverHandler(btn,null);
//            int aftersave = UserAnswer.getAll().Count;
//            Assert.AreEqual(beforSave+1, aftersave);
//        }
//    }
//}
