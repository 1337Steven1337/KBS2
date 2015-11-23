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
        public RichTextBox questionField;
        public NumericUpDown pointsField, timeField;
        public Label questionFieldLabel, pointsFieldLabel, timeFieldLabel;

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
            addQuestionForm.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));

            questionField = new RichTextBox();
            questionField.Dock = DockStyle.Fill;

            questionFieldLabel = new Label();
            questionFieldLabel.Text = "Vraag: ";
            questionFieldLabel.Dock = DockStyle.Fill;

            pointsField = new NumericUpDown();
            pointsField.Dock = DockStyle.Fill;

            pointsFieldLabel = new Label();
            pointsFieldLabel.Text = "Punten vraag: ";
            pointsFieldLabel.Dock = DockStyle.Fill;

            timeField = new NumericUpDown();
            timeField.Dock = DockStyle.Fill;

            timeFieldLabel = new Label();
            timeFieldLabel.Text = "Tijdslimiet (seconden): ";
            timeFieldLabel.Dock = DockStyle.Fill;
          
            addQuestionForm.Controls.Add(questionFieldLabel, 0, 0);
            addQuestionForm.Controls.Add(questionField, 1, 0);

            addQuestionForm.Controls.Add(pointsFieldLabel, 0, 1);
            addQuestionForm.Controls.Add(pointsField, 1, 1);

            addQuestionForm.Controls.Add(timeFieldLabel, 0, 2);
            addQuestionForm.Controls.Add(timeField, 1, 2);

            middleRow.Controls.Add(addQuestionForm);
        }


    }
}
