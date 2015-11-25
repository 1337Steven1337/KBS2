using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class PanelRight : PanelLayout
    {
        private TableLayoutPanel addQuestionForm;
        public Label questionFieldLabel, pointsFieldLabel, timeFieldLabel, predefinedAnswersListLabel, predefinedAnswerFieldLabel;
        public RichTextBox questionField;
        public NumericUpDown pointsField, timeField;        
        public ListBox predefinedAnswersList;
        private TextBox predefinedAnswerField;
        private Button addAnswerBtn, removeAnswerBtn;

        public PanelRight(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm)
        {
            bottomRow.Controls.Clear();
            bottomRow.Controls.Add(leftBottomButton, 0, 0);

            leftBottomButton.Text = "Opslaan";

            //Place the maintable in 3/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 2, 0);
        }        

        public void loadAddQuestionForm()
        {
            addQuestionForm = new TableLayoutPanel();
            addQuestionForm.Dock = DockStyle.Fill;
            addQuestionForm.Margin = new Padding(0);
                     
            addQuestionForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            addQuestionForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addQuestionForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            addQuestionForm.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));

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

            predefinedAnswersListLabel = new Label();
            predefinedAnswersListLabel.Text = "Antwoorden: ";

            predefinedAnswersList = new ListBox();
            predefinedAnswersList.Dock = DockStyle.Fill;

            predefinedAnswerFieldLabel = new Label();
            predefinedAnswerFieldLabel.Text = "Voer hier een antwoord in: ";
            predefinedAnswerFieldLabel.AutoSize = true;

            predefinedAnswerField = new TextBox();
            predefinedAnswerField.Dock = DockStyle.Fill;

            addAnswerBtn = new Button();
            addAnswerBtn.Text = ">";
            addAnswerBtn.Click += addAnswerHandler;

            removeAnswerBtn = new Button();
            removeAnswerBtn.Text = "x";            
            removeAnswerBtn.Click += removeAnswerHandler;

            addQuestionForm.Controls.Add(questionFieldLabel, 0, 0);
            addQuestionForm.Controls.Add(questionField, 1, 0);

            addQuestionForm.Controls.Add(timeFieldLabel, 0, 1);
            addQuestionForm.Controls.Add(timeField, 1, 1);

            addQuestionForm.Controls.Add(pointsFieldLabel, 0, 2);
            addQuestionForm.Controls.Add(pointsField, 1, 2);
            
            addQuestionForm.Controls.Add(predefinedAnswersListLabel, 0, 3);
            addQuestionForm.Controls.Add(predefinedAnswersList, 1, 3);
            addQuestionForm.Controls.Add(removeAnswerBtn, 2, 3);

            addQuestionForm.Controls.Add(predefinedAnswerFieldLabel, 0, 5);
            addQuestionForm.Controls.Add(predefinedAnswerField, 1, 5);
            addQuestionForm.Controls.Add(addAnswerBtn, 2, 5);

            middleRow.Controls.Add(addQuestionForm);
        }

        private void addAnswerHandler(object sender, EventArgs e)
        {
            //Check if field is not empty
            if(predefinedAnswerField.Text.Length != 0)
            {
                Boolean listExists = false;

                foreach (var answer in predefinedAnswersList.Items)
                {
                    if (answer.Equals(predefinedAnswerField.Text))
                    {
                        listExists = true;
                    }
                }

                if (!listExists)
                {
                    predefinedAnswersList.Items.Add(predefinedAnswerField.Text);
                }                
            }           
        }

        private void removeAnswerHandler(object sender, EventArgs e)
        {
            if(predefinedAnswersList.SelectedIndex >= 0)
            {
                predefinedAnswersList.Items.Remove(predefinedAnswersList.SelectedItem);
            }

        }
    }
}
