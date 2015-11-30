using Client.Controller;
using Client.View.PanelLayout;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client.View.QuestionList
{
    public interface IQuestionListView
    {
        void setController(QuestionListController controller);
        ListBox getListBox();
        CustomPanel getCustomPanel();
        void fillList(List<Model.QuestionList> lists);
    }
}
