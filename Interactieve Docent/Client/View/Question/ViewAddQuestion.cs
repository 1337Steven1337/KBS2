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
        private CustomPanel customPanel;
        private TableLayoutPanel addQuestionTable;
        private Label questionFieldLabel, pointsFieldLabel, timeFieldLabel, answersListBoxLabel, answerFieldLabel, rightAnswerComboBoxLabel;
        private RichTextBox questionField;
        private ListBox answersListBox;
        private TextBox answerField;
        private ComboBox rightAnswerComboBox;
        private NumericUpDown pointsField, timeField;
        private Button addAnswerBtn, removeAnswerBtn;

        public ViewAddQuestion()
        {
            InitializeComponent();
            customPanel = new CustomPanel();

            addQuestionTable = new TableLayoutPanel();
            addQuestionTable.Dock = DockStyle.Fill;
            addQuestionTable.Margin = new Padding(0);

            addQuestionTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            addQuestionTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addQuestionTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            addQuestionTable.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));

            questionField = new RichTextBox();
            questionField.Dock = DockStyle.Fill;

            questionFieldLabel = new Label();
            questionFieldLabel.Text = "Vraag: ";
            questionFieldLabel.Dock = DockStyle.Fill;

            timeField = new NumericUpDown();
            timeField.Dock = DockStyle.Fill;

            timeFieldLabel = new Label();
            timeFieldLabel.Text = "Tijdslimiet (seconden): ";
            timeFieldLabel.Dock = DockStyle.Fill;

            pointsField = new NumericUpDown();
            pointsField.Dock = DockStyle.Fill;

            pointsFieldLabel = new Label();
            pointsFieldLabel.Text = "Punten vraag: ";
            pointsFieldLabel.Dock = DockStyle.Fill;

            answersListBoxLabel = new Label();
            answersListBoxLabel.Text = "Antwoorden: ";

            answersListBox = new ListBox();
            answersListBox.Dock = DockStyle.Fill;

            answerFieldLabel = new Label();
            answerFieldLabel.Text = "Voer hier een antwoord in: ";
            answerFieldLabel.AutoSize = true;

            answerField = new TextBox();
            answerField.Dock = DockStyle.Fill;

            addAnswerBtn = new Button();
            addAnswerBtn.Text = ">";

            removeAnswerBtn = new Button();
            removeAnswerBtn.Text = "x";

            rightAnswerComboBoxLabel = new Label();
            rightAnswerComboBoxLabel.Text = "Het juiste antwoord: ";
            rightAnswerComboBoxLabel.Dock = DockStyle.Fill;

            rightAnswerComboBox = new ComboBox();
            rightAnswerComboBox.Dock = DockStyle.Fill;
            rightAnswerComboBox.Text = "Kies het juiste antwoord";

            addQuestionTable.Controls.Add(questionFieldLabel, 0, 0);
            addQuestionTable.Controls.Add(questionField, 1, 0);

            addQuestionTable.Controls.Add(timeFieldLabel, 0, 1);
            addQuestionTable.Controls.Add(timeField, 1, 1);

            addQuestionTable.Controls.Add(pointsFieldLabel, 0, 2);
            addQuestionTable.Controls.Add(pointsField, 1, 2);

            addQuestionTable.Controls.Add(answersListBoxLabel, 0, 3);
            addQuestionTable.Controls.Add(answersListBox, 1, 3);
            addQuestionTable.Controls.Add(removeAnswerBtn, 2, 3);

            addQuestionTable.Controls.Add(answerFieldLabel, 0, 5);
            addQuestionTable.Controls.Add(answerField, 1, 5);
            addQuestionTable.Controls.Add(addAnswerBtn, 2, 5);

            addQuestionTable.Controls.Add(rightAnswerComboBoxLabel, 0, 6);
            addQuestionTable.Controls.Add(rightAnswerComboBox, 1, 6);
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
        }

        public TableLayoutPanel getTable()
        {
            return addQuestionTable;
        }

        public CustomPanel getCustomPanel()
        {
            return customPanel;
        }

        public Button getAddAnswerBtn()
        {
            return addAnswerBtn;        
        }

        public Button getRemoveAnswerBtn()
        {
            return removeAnswerBtn;
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
