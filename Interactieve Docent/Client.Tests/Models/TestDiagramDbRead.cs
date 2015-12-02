using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Controllers;
using Server.Models;

namespace Client.Tests.Models
{
    /// <summary>
    /// Summary description for UserAnswer
    /// </summary>
    [TestClass]
    public class TestDiagramDbRead
    {
        [TestMethod]
        public async Task PostList_ShouldReturnSameId()
        {
            //var controller = new diagram();

            //var item = GetTestList();

            //var result = 
            //    await controller.PostUserAnswer(item) as CreatedAtRouteNegotiatedContentResult<UserAnswer>;

        }

        private UserAnswer GetTestList()
        {
            return new UserAnswer() { Id = 1, Question_Id = 3, PredefinedAnswer_Id = 1 };
        }
    }
}
