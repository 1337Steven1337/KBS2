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
    
    class PanelLeft : PanelLayout
    {
        public ListBox listBox;

        public PanelLeft(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm)
        {
            title.Text = "VragenLijsten";
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            middleRow.Controls.Add(listBox);
            LoadList();
            
            leftBottomButton.Click += removeList;

            //Place the maintable in 1/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 0, 0);
        }

        public void LoadList()
        {
            listBox.DataSource = List.getAll();
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";            
        }

        private void removeList(object sender, EventArgs e)
        {
            MessageBox.Show("Weet u zeker dat u de lijst: " + listBox.SelectedItem.ToString() +" wilt verwijderen?");            
        }


    }
}
