using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class DocentControlUI : Form
    {
        public DocentControlUI()
        {       
            InitializeComponent();
            TableLayoutPanel panelsTable = new TableLayoutPanel();
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
            panelsTable.Dock = DockStyle.Fill;
            panelsTable.ColumnCount = 3;
            panelsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            panelsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            panelsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            
            PanelLeft panelLeft = new PanelLeft(this, panelsTable);
            PanelMiddle panelMiddle = new PanelMiddle(this, panelsTable);
            PanelRight panelRight = new PanelRight(this, panelsTable);  
            
                    
                      
            this.Controls.Add(panelsTable);
        }
    }
}
