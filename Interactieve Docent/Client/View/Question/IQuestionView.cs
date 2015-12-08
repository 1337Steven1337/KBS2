using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Model;
using System;

namespace Client.View.Question
{
    public interface IQuestionView<T> : IListView<T> where T : AbstractModel, new()
    {
        void setController(QuestionController controller);
        void SetTable<C>(C threeColTable);

        //ListBox getListBoxQuestions();
        List<Model.Question> getQuestionList();
        TableLayoutPanel getPanel();

    }
}
