using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Controllers;
using Server.Tests.Models.Context;
using System.Web.Http.Results;
using System.Threading.Tasks;
using Server.Models;
using System.Web.Http;
using System.Net;
using Server.Models.DTO;

namespace Server.Tests.Controllers
{
    /// <summary>
    /// Summary description for TestListController
    /// </summary>
    [TestClass]
    public class TestListController
    {
        private ListsController controller = new ListsController(new TestServerContext());

        [TestMethod]
        public async Task PostList_ShouldReturnSameList()
        {
            QuestionList item = GetTestList();

            var result =
                await controller.PostList(item) as CreatedAtRouteNegotiatedContentResult<QuestionList>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
            Assert.AreEqual(result.Content.Name, item.Name);
        }

        [TestMethod]
        public async Task UpdateList_ShouldReturnNoContent()
        {
            QuestionList item = GetTestList();
            item.Name = "Abc list";

            StatusCodeResult result =
                await controller.PutList(item.Id, item) as StatusCodeResult;

            Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        }

        private QuestionList GetTestList()
        {
            return new QuestionList() { Id = 3, Name = "Test list" };
        }
    }
}
