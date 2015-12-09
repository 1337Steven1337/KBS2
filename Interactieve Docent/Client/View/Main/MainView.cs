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
    public partial class MainView : Form, IView
    {
        private MainController controller;

        public MainView()
        {
            InitializeComponent();

            
        }

        //Remove third column from mainView
        public void RemoveAddQuestionPanel()
        {
            tableThreeColumn.SuspendLayout();
            tableThreeColumn.Controls.RemoveAt(2);
            float width = 0;
            for (int i = 0; i < tableThreeColumn.ColumnCount; i++)
            {
                if (i < 2)
                {
                    width = 50F;
                }
                else
                {
                    width = 0;
                }
                tableThreeColumn.ColumnStyles[i].Width = width;
            }
            tableThreeColumn.ResumeLayout(true);
            tableThreeColumn.PerformLayout();
        }

        //Add view to mainTable 
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

        public IControlHandler GetHandler()
        {
            throw new NotImplementedException();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this.controller = (MainController)controller;
        }
    }
}
