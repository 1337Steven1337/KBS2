using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.View.PanelLayout;
using Client.Factory;

namespace Client.View.Question
{
    public partial class ViewAddQuestion : Form, IAddQuestionView
    {
        private QuestionController controller;

        public ViewAddQuestion()
        {
            InitializeComponent();
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
        }

        public TableLayoutPanel getPanel()
        {
            return mainTablePanel;
        }

        public Button getBtnSaveQuestion()
        {
            return btnSaveQuestion;
        }

        public Button getBtnQuit()
        {
            return btnQuit;
        }

        public Button getBtnAddAnswer()
        {
            return btnAddAnswer;        
        }

        public Button getBtnDeleteAnswer()
        {
            return btnDeleteAnswer;
        }

        public RichTextBox getQuestionField()
        {
            return questionField;
        }

        public NumericUpDown getPointsField()
        {
            return pointsField;
        }

        public NumericUpDown getTimeField()
        {
            return timeField;
        }
        
        public ListBox getAnswersListBox()
        {
            return answersListBox;
        }

        public TextBox getAnswerField()
        {
            return answerField;
        }

        public ComboBox getRightAnswerComboBox()
        {
            return rightAnswerComboBox;
        }        
    }
}
