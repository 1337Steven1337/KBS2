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
using System.Net;

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


        //Checks the HTTP response, if it is not Created then tell the teacher something went wrong.
        private void sessionSaveCallBackHandler(Model.Pincode pin, HttpStatusCode code)
        {
            if (code != HttpStatusCode.Created)
            {
                MessageBox.Show("Er ging iets mis met het maken van een sessie.");
                Application.Exit();
            }
        }

        //Checks the HTTP response
        private void sessionCheckCallBackHandler(Model.Pincode pin, HttpStatusCode code)
        {
            if (code == HttpStatusCode.OK)
            {
                MessageBox.Show("Er ging iets mis met het maken van een sessie.");
            }else if(code == HttpStatusCode.NotFound){
                Factory.PincodeFactory pinFactory = new Client.Factory.PincodeFactory();
                pinFactory.Save(pin, new ControlHandler(sessionLabel), sessionSaveCallBackHandler);
            }

        }

        //Generate sessionID
        public void GenerateSessionId()
        {
            string sessionToken = Client.Service.Generate.Token.GenerateToken(6);

            Model.Pincode pincode = new Model.Pincode();
            pincode.Id = Convert.ToInt32(sessionToken);

            //Change property in settings
            Properties.Settings.Default.Session_Id = pincode.Id;
            Properties.Settings.Default.Save();

            //Set sessionId label
            this.sessionLabel.Text = sessionToken;

            //Add session to the database
            Factory.PincodeFactory pincodeFactory = new Client.Factory.PincodeFactory();
            pincodeFactory.FindById(pincode.Id, new ControlHandler(sessionLabel),sessionCheckCallBackHandler); 
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
    }
}
