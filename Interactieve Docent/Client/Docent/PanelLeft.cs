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
            listBox.BorderStyle = BorderStyle.None;

            LoadList();           
            middleRow.Controls.Add(listBox);
            //Place the maintable in 1/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 0, 0);
        }

        //Load all question lists in a Listbox
        public void LoadList()
        {
            listBox.DataSource = List.getAll();
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
        }
    }
}
