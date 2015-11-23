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
        public PanelRight(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm)
        {


            //Place the maintable in 3/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 2, 0);
        }        
    }
}
