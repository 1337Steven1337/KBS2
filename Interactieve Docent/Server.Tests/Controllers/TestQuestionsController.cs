using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Models;
using Server.Tests.Models.Context;
using Server.Controllers;
using System.Threading.Tasks;
using System.Web.Http.Results;
using System.Net;

namespace Server.Tests.Controllers
{
    [TestClass]
    public class TestQuestionsController
    {
        private QuestionsController controller = new QuestionsController(new TestServerContext());

        [TestMethod]
        public async Task PostQuestion_ShouldReturnSameId()
        {
            Question item = GetTestQuestion();

            var result =
                await controller.PostQuestion(item) as CreatedAtRouteNegotiatedContentResult<Question>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
            Assert.AreEqual(result.Content.Text, item.Text);
        }

        [TestMethod]
        public async Task UpdateQuestion_ShouldReturnNoContent()
        {
            Question item = GetTestQuestion();
            item.Text = "This might work?";

            StatusCodeResult result =
                await controller.PutQuestion(item.Id, item) as StatusCodeResult;

            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

        private Question GetTestQuestion()
        {
            return new Question() { Id = 1, Text = "Does this even work?", Time = 10, Points = 9001 };
        }
    }
}
