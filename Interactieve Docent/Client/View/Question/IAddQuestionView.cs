using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;

namespace Client.View.Question
{
    public interface IAddQuestionView<T> : IListView<T> where T : AbstractModel, new()
    {
        void setController(QuestionController controller);
        TableLayoutPanel getPanel();
        Button getBtnSaveQuestion();
        Button getBtnQuit();
        Button getBtnAddAnswer();
        Button getBtnDeleteAnswer();
        RichTextBox getQuestionField();
        NumericUpDown getPointsField();
        NumericUpDown getTimeField();
        ListBox getAnswersListBox();
        TextBox getAnswerField();
        ComboBox getRightAnswerComboBox();
    }
}
