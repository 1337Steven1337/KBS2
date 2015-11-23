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
        public ListBox listBox;

        public PanelMiddle(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm)
        {
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.BorderStyle = BorderStyle.None;

            middleRow.Controls.Add(listBox);
            leftBottomButton.Text = "Nieuwe vraag";
            //Place the maintable in 2/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 1, 0);
        }

        public void loadQuestionList(int listIndex)
        {
            title.Text = "Vragen uit lijst: " + List.getById(listIndex).Name;                        
            listBox.DataSource = List.getById(listIndex).Questions;
            listBox.DisplayMember = "Text";
            listBox.ValueMember = "Id";
        }
    }
}
