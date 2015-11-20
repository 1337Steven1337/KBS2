using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class PanelLeft : PanelLayout
    {
        private ListBox listBox;

        public PanelLeft(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm, panelsTable)
        {
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.Items.Add("Test");            
            middleRow.Controls.Add(listBox);            

            //Place the maintable in 1/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 0, 0);
        }        
    }
}
