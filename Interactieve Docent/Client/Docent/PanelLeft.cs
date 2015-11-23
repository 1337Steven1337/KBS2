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

            leftBottomButton.Click += leftButton_Click;
            leftBottomButton.Text = "Add List";

            middleRow.Controls.Add(listBox);
            LoadList();
            
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

        public void leftButton_Click(object sender, EventArgs e)
        {
            Docent.AddList newList = new Docent.AddList();
            newList.ShowDialog();

            if (newList.valid)
            {
                List list = new List();
                list.Name = newList.name;
                list.save();

                LoadList();
            }
        }
    }
}
