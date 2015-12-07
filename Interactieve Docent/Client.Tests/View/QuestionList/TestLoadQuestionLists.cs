using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Controller;
using Client.Tests.Factory;

namespace Client.Tests.View.QuestionList
{
    [TestClass]
    public class TestLoadQuestionLists
    {
        [TestMethod]
        public void CreateTestViewQuestionList_ShouldReturnItemCountOffThree()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            QuestionListController controller = new QuestionListController(view);
            controller.factory.SetBaseFactory(new TestQuestionListFactory());
            controller.loadLists();

            int expected = 3;
            int result = view.getCount();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddItemToList_ShouldReturnItemCountOffFour()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            QuestionListController controller = new QuestionListController(view);
            controller.factory.SetBaseFactory(new TestQuestionListFactory());
            controller.loadLists();
            Model.QuestionList ql = new Model.QuestionList();
            view.Add(ql);

            int expected = 4;
            int result = view.getCount();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveItemFromListWithIndex_ShouldReturnItemCountOffTwo()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            QuestionListController controller = new QuestionListController(view);
            controller.factory.SetBaseFactory(new TestQuestionListFactory());
            controller.loadLists();
            view.RemoveAt(1);

            int expected = 2;
            int result = view.getCount();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SelectListByListId_ShouldReturnRightIdAndName()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            QuestionListController controller = new QuestionListController(view);
            controller.factory.SetBaseFactory(new TestQuestionListFactory());
            controller.loadLists();

            int expectedId = 2;
            string expectedName = "2";

            Model.QuestionList q = view.getById(2);
            int resultId = q.Id;
            string resultName = q.Name;

            Assert.AreEqual(expectedId, resultId);
            Assert.AreEqual(expectedName, resultName);
        }

        [TestMethod]
        public void SelectListByIndex_ShouldReturnRightIdAndName()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            QuestionListController controller = new QuestionListController(view);
            controller.factory.SetBaseFactory(new TestQuestionListFactory());
            controller.loadLists();

            int expectedId = 2;
            string expectedName = "2";

            Model.QuestionList q = view.getItem(1);
            int resultId = q.Id;
            string resultName = q.Name;

            Assert.AreEqual(expectedId, resultId);
            Assert.AreEqual(expectedName, resultName);
        }
    }
}
