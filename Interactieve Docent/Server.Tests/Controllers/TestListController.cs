using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Controllers;
using Server.Tests.Models.Context;
using Server.Models;
using System.Web.Http.Results;
using System.Threading.Tasks;

namespace Server.Tests.Controllers
{
    /// <summary>
    /// Summary description for TestListController
    /// </summary>
    [TestClass]
    public class TestListController
    {
        [TestMethod]
        public async Task PostList_ShouldReturnSameList()
        {
            var controller = new ListsController(new TestServerContext());

            var item = GetTestList();

            var result =
                await controller.PostList(item) as CreatedAtRouteNegotiatedContentResult<List>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
            Assert.AreEqual(result.Content.Name, item.Name);
        }

        private List GetTestList()
        {
            return new List() { Id = 3, Name = "Test list" };
        }
    }
}
