using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Model;
using System;

namespace Client.View.Question
{
    public interface IQuestionView : IView
    {
        void setController(QuestionController controller);
        void SetTable<T>(T threeColTable);

        //ListBox getListBoxQuestions();
        List<Model.Question> getQuestionList();
        TableLayoutPanel getPanel();

    }
}
