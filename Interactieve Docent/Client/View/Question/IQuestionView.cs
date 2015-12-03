using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.View.PanelLayout;
using Client.Model;
using System;

namespace Client.View.Question
{
    public interface IQuestionView
    {
        void setController(QuestionController controller);
        ListBox getListBox();
        CustomPanel getCustomPanel();        
    }
}
