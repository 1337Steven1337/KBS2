using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Service.Thread;

namespace Client.View.Main
{
    public partial class ViewMain : Form, IViewMain
    {
        private MainController controller;

        public ViewMain()
        {
            InitializeComponent();
        }

        public void setController(MainController controller)
        {
            this.controller = controller;
        }

        public void AddTablePanel(TableLayoutPanel panel, int column)
        {
            this.tableThreeColumn.Controls.Add(panel, column, 0);

            this.tableThreeColumn.SuspendLayout();
            for (int i = 0; i < this.tableThreeColumn.ColumnCount; i++)
            {
                float width;

                if(this.tableThreeColumn.ColumnStyles[2].Width > 0)
                {
                    if (i != 2)
                    {
                        width = 30F;
                    }
                    else
                    {
                        width = 40F;
                    }
                }
                else
                {
                    width = 50F;
                }

                this.tableThreeColumn.ColumnStyles[i].Width = width;

            }
            this.tableThreeColumn.ResumeLayout(true);
            this.tableThreeColumn.PerformLayout();
        }

        public IControlHandler getHandler()
        {
            throw new NotImplementedException();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }
    }
}
