using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Model;
using System;

namespace Client.View.Question
{
    public interface IQuestionView
    {
        void setController(QuestionController controller);
        ListBox getListBoxQuestions();
        Button getBtnAddQuestion();
        Button getBtnDeleteQuestion();
        Button getBtnShowResults();
        TableLayoutPanel getPanel();

    }
}
