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
        ListBox getListBoxQuestionLists();
        Button getBtnAddQuestionList();
        Button getBtnDeleteQuestionList();
        TableLayoutPanel getPanel();
    }
}
