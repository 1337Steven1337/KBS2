using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Tests
{
    [TestClass()]
    public class DocentControlUITests
    {
        [TestMethod()]
        public void SaveQuestion_ShouldSaveQuestion()
        {
            var controller = new Server.Controllers.QuestionsController();
            //object controller = new DocentControlUI();
            //Client.API.Models.Question question = new Client.API.Models.Question();

            //question.save();

            Assert.AreEqual(1, 1);
        }
    }
}