using Client.Controller;
using Client.Controller.QuestionList;
using Client.Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace Client.View.QuestionList
{
    public interface IQuestionListView<T> : IListView<T> where T : AbstractModel, new()
    {
        void Add(Model.QuestionList ql);
        void setController(ListQuestionListController controller);
        List<Model.QuestionList> getQuestionlists();
        Model.QuestionList getSelectedItem();
        int getCount();
        Model.QuestionList getById(int i);
        Model.QuestionList getItem(int i);
        void RemoveAt(int i);
    }
}
