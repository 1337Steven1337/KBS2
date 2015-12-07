using Client.Controller;
using System.Collections.Generic;
using System.ComponentModel;

namespace Client.View.QuestionList
{
    public interface IQuestionListView : IView
    {
        void Add(Model.QuestionList ql);
        void setController(QuestionListController controller);
        List<Model.QuestionList> getQuestionlists();
        Model.QuestionList getSelectedItem();
        int getCount();
        Model.QuestionList getItem(int i);
        void RemoveAt(int i);
    }
}
