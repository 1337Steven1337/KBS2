using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Controller;
using Client.Tests.Factory;
using Client.Controller.QuestionList;

namespace Client.Tests.View.QuestionList
{
    [TestClass]
    public class TestLoadQuestionLists
    {
        [TestMethod]
        public void CreateTestViewQuestionList_ShouldReturnItemCountOffThree()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            Assert.AreEqual(view.getCount(), 3);
        }

        [TestMethod]
        public void AddItemToList_ShouldReturnItemCountOffFour()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            view.AddItem(new Model.QuestionList());

            Assert.AreEqual(view.getCount(), 4);
        }

        [TestMethod]
        public void RemoveItemFromListWithIndex_ShouldReturnItemCountOffTwo()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            view.RemoveAt(1);

            Assert.AreEqual(view.getCount(), 2);
        }

        [TestMethod]
        public void SelectListByListId_ShouldReturnRightIdAndName()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();
            Model.QuestionList list = view.getById(2);

            Assert.AreEqual(list.Id, 2);
            Assert.AreEqual(list.Name, "2");
        }

        [TestMethod]
        public void SelectListByIndex_ShouldReturnRightIdAndName()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();
            Model.QuestionList list = view.getItem(1);

            Assert.AreEqual(list.Id, 2);
            Assert.AreEqual(list.Name, "2");
        }

        [TestMethod]
        public void SelectListByIdWithTwoQuestions_ShouldReturnQuestionAmountOfTwo()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            Model.Question q = new Model.Question();
            view.AddToList(q, 1);
            view.AddToList(q, 2);
            view.AddToList(q, 2);

            Model.QuestionList list = view.getById(2);

            Assert.AreEqual(list.Questions.Count, 2);
        }

        [TestMethod]
        public void SelectListByIndexWithTwoQuestions_ShouldReturnQuestionAmountOfTwo()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            Model.Question q = new Model.Question();
            view.AddToList(q, 1);
            view.AddToList(q, 2);
            view.AddToList(q, 2);

            Model.QuestionList list = view.getItem(1);

            Assert.AreEqual(list.Id, 2);
        }

        [TestMethod]
        public void SelectListByIdWithNoQuestions_ShouldReturnQuestionAmountOfZero()
        {
            TestViewQuestionList view = new TestViewQuestionList();
            ListQuestionListController QuestionListController = new ListQuestionListController(view);
            QuestionListController.SetBaseFactory(new TestQuestionListFactory());
            QuestionListController.Load();

            Model.QuestionList list = view.getQuestionlists()[1];

            Assert.AreEqual(list.Questions.Count, 0);
        }
    }
}
