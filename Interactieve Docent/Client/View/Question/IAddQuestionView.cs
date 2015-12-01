using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.View.PanelLayout;
using Client.Controller;


namespace Client.View.Question
{
    public interface IAddQuestionView
    {
        void setController(QuestionController controller);
        TableLayoutPanel getTable();
        CustomPanel getCustomPanel();
        Button getAddAnswerBtn();
        Button getRemoveAnswerBtn();
        RichTextBox getQuestionField();
        NumericUpDown getPointsField();
        NumericUpDown getTimeField();
        ListBox getAnswersListBox();
        TextBox getAnswerField();
        ComboBox getRightAnswerComboBox();       
    }
}
