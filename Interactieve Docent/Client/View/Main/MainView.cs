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
using Client.View.Account;
using Client.Controller.Account;
using Client.View.Question;
using Client.View.Dialogs;
using Client.View.OpenQuestion;
using Client.Controller.OpenQuestion;

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
        public void RemoveAddQuestionPanel(bool resizeTable)
        {
            tableFourColumn.SuspendLayout();
            tableFourColumn.Controls.RemoveAt(3);
            if (resizeTable)
            {
                float width = 0;
                for (int i = 0; i < tableFourColumn.ColumnCount; i++)
                {
                    if (i == 0)
                    {
                        width = 10F;
                    }
                    else if (i > 0 && i < 3)
                    {
                        width = 45F;
                    }
                    else
                    {
                        width = 0F;
                    }
                    tableFourColumn.ColumnStyles[i].Width = width;
                }
            }
            tableFourColumn.ResumeLayout(true);
            tableFourColumn.PerformLayout();
        }

        //Add view to mainTable 
        public void AddTablePanel(TableLayoutPanel panel, int column)
        {
            Boolean column4IsSet = false;
            if (column == 3)
            {
                column4IsSet = true;
            }

            this.tableFourColumn.Controls.Add(panel, column, 0);
            this.tableFourColumn.SuspendLayout();
            for (int i = 0; i < this.tableFourColumn.ColumnCount; i++)
            {
                float width;
                if (column4IsSet) {                 
                    if(i == 0)
                    {
                        width = 10F;
                    }
                    else if (i > 0 && i < 3)
                    {
                        width = 25F;
                    }
                    else
                    {
                        width = 40F;
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        width = 10F;
                    }
                    else if (i > 0 && i < 3) 
                    {
                        width = 45F;
                    }
                    else
                    {
                        width = 0F;
                    }
                }
                this.tableFourColumn.ColumnStyles[i].Width = width;
            }
            this.tableFourColumn.ResumeLayout(true);
            this.tableFourColumn.PerformLayout();
        }

        public void Confirm(bool edit)
        {
            DialogResult dr = new DialogResult();
            ConfirmDialogView confirm = new ConfirmDialogView();
            if (edit)
            {
                confirm.getLabelConfirm().Text = "";
            }
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

        private void ImportAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountView view = new AddAccountView();
            AddAccountController controller = new AddAccountController(view);

            BackgroundDialogView background = new BackgroundDialogView(this, view);
        }

        private void OpenQuestionButton_Click(object sender, EventArgs e)
        {
            AddOpenQuestionView view = new AddOpenQuestionView();
            AddOpenQuestionController controller = new AddOpenQuestionController(view);

            BackgroundDialogView background = new BackgroundDialogView(this, view);
        }
    }
}
