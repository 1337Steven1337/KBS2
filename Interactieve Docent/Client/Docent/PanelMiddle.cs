using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class PanelMiddle : PanelLayout
    {
        public PanelMiddle(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm, panelsTable)
        {

            //Place the maintable in 2/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 1, 0);
        }        
    }
}
