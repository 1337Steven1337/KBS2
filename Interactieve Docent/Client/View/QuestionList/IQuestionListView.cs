using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.View.QuestionList
{
    public interface IQuestionListView
    {
        void setController(QuestionListController controller);
        Panel getPanel();
        void fillList(List<Model.QuestionList> lists);
    }
}
