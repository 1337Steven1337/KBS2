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
        private TableLayoutPanel formTable = new TableLayoutPanel();
        public PanelRight(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm)
        {
            formTable.Dock = DockStyle.Fill;
            formTable.ColumnCount = 1;
            //formTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));


            middleRow.Controls.Add(formTable);

            //Place the maintable in 3/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 2, 0);
        }        
    }
}
