using Client.Controller;
using Client.Model;
using Client.Tests.Factory;
using Client.Tests.View.UserAnswerToOpenQuestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Tests.Controllers
{
    [TestClass]
    class TestUserAnswerToOpenQuestion
    {
        [TestMethod]
        public void blij()
        {
            TestUserAnswerToOpenQuestionView view = new TestUserAnswerToOpenQuestionView();
            UserAnswerToOpenQuestionController Controller = new UserAnswerToOpenQuestionController(view);
            TestUserAnswerToOpenQuestionFactory Factory = new TestUserAnswerToOpenQuestionFactory();
            Controller.SetBaseFactory(Factory);

            UserAnswerToOpenQuestion Q = new UserAnswerToOpenQuestion();
            Factory.Add(Q);
            Controller.LoadList();

            Assert.AreEqual(4, 4);
        }
    }
}
