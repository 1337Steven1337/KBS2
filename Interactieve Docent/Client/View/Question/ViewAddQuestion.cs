using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.View.Main;

namespace Client.View.Question
{
    public partial class ViewAddQuestion : Form, IAddQuestionView<Model.Question>
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

        public void AddToParent(IView parent)
        {
            ViewMain main = (ViewMain)parent;

            main.AddTablePanel(this.mainTablePanel,2);
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

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.answersListBox);
        }

        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }

        public void FillList(List<Model.Question> list)
        {
            throw new NotImplementedException();
        }
    }
}
