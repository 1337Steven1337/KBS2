using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.API.Models;

namespace Client
{
    class PanelMiddle : PanelLayout
    {
        private int questionId;
        public ListBox listBox;

        public PanelMiddle(Form mainForm, TableLayoutPanel panelsTable) : base()
        {
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            middleRow.Controls.Add(listBox);
            rightBottomButton.Text = "Delete Question";
            listBox.BorderStyle = BorderStyle.None;

            middleRow.Controls.Add(listBox);
            leftBottomButton.Text = "Nieuwe vraag";
            //Place the maintable in 2/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 1, 0);
        }

        public void loadQuestionList(int listIndex)
        {
            questionId = listIndex;
            title.Text = "Vragen uit lijst: " + List.getById(listIndex).Name;                        
            listBox.DataSource = List.getById(listIndex).Questions;
            listBox.DisplayMember = "Text";
            listBox.ValueMember = "Id";
        }

        public void deleteQuestion()
        {
            Docent.DeletePopup Delete = new Docent.DeletePopup();
            Delete.ShowDialog();

            if (Delete.valid)
            {
                int selected = listBox.SelectedIndex;

                Question question = new Question();
                int id = Convert.ToInt32(listBox.SelectedValue);
                question.Id = id;
                question.Delete();

                loadQuestionList(questionId);

                if (selected != 0){
                    listBox.SelectedIndex = selected - 1;
                }
            }
        }
    }
}
