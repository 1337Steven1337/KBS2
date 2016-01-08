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
using Client.View.OpenQuestion;
using Client.Controller.OpenQuestion;
using Client.Factory;
using Client.Model;
using RestSharp;

namespace Client.View.Main
{
    public partial class MainView : Form, IView
    {
        private MainController controller;
        private int sessionPin = 0;

        OpenQuestionFactory openQuestionFactory = new OpenQuestionFactory();
        AccountFactory accountFactory = new AccountFactory();
        UserAnswerFactory userAnswerFactory = new UserAnswerFactory();
        Boolean removed = true;
        int count = 0;

        public MainView()
        {
            InitializeComponent();
            GenerateSessionId();
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
                MessageBox.Show("Er ging iets mis met het maken van een sessie, gelieve de applicatie opnieuw opstarten.");
                Application.Exit();
            }
        }

        //Checks the HTTP response
        private void sessionCheckCallBackHandler(Model.Pincode pin, HttpStatusCode code)
        {
            if (code == HttpStatusCode.Found)
            {
                GenerateSessionId();
            }else if(code == HttpStatusCode.NotFound){
                Factory.PincodeFactory pinFactory = new Client.Factory.PincodeFactory();
                pin = new Model.Pincode();
                pin.Id = sessionPin;
                pinFactory.Save(pin, new ControlHandler(sessionLabel), sessionSaveCallBackHandler);
            }
        }

        //Generate sessionID
        public void GenerateSessionId()
        {
            int sessionToken = Client.Service.Generate.Token.GenerateSessionId(6);
            
            sessionPin = sessionToken;

            //Change property in settings
            Properties.Settings.Default.Session_Id = sessionPin;
            Properties.Settings.Default.Save();

            //Set sessionId label
            this.sessionLabel.Text = sessionToken.ToString();

            //Add session to the database
            Factory.PincodeFactory pincodeFactory = new Client.Factory.PincodeFactory();
            pincodeFactory.FindById(sessionPin, new ControlHandler(sessionLabel), sessionCheckCallBackHandler); 
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
            return new ControlHandler(this.tableFourColumn);
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

        private void EndSessionButton_Click(object sender, EventArgs e)
        {
            openQuestionFactory.FindAll(this.GetHandler(), DeleteSession);
            userAnswerFactory.FindAll(this.GetHandler(), DeleteSession);
            accountFactory.FindAll(this.GetHandler(), DeleteSession);
        }

        private void DeleteSession(List<Model.OpenQuestion> arg1, HttpStatusCode arg2, IRestResponse arg3)
        {
            foreach (Model.OpenQuestion item in arg1)
            {
                openQuestionFactory.Delete(item, this.GetHandler(), CallBackDeleted);
            }
            DeletedStatus();
        }

        private void DeleteSession(List<Model.Account> arg1, HttpStatusCode arg2, IRestResponse arg3)
        {
            foreach (Model.Account item in arg1)
            {
                accountFactory.Delete(item, this.GetHandler(), CallBackDeleted);
            }
            DeletedStatus();
        }

        private void DeleteSession(List<Model.UserAnswer> arg1, HttpStatusCode arg2, IRestResponse arg3)
        {
            foreach (Model.UserAnswer item in arg1)
            {
                userAnswerFactory.Delete(item, this.GetHandler(), CallBackDeleted);
            }
            DeletedStatus();
        }

        private void CallBackDeleted(Model.AbstractModel model, HttpStatusCode status)
        {
            //Check if all the to-be-deleted records have been deleted, if one has failed, removed is false
            if(status != HttpStatusCode.OK)
            {
                removed = false;
            }
        }

        private void DeletedStatus()
        {
            count++;
            //Check if accounts, openquestions and useranswers have been removed
            if (count == 3)
            {
                if (removed)
                {
                    //If everything is succesfully removed show succes
                    SuccesDialogView view = new SuccesDialogView();
                    view.Text = "Verwijderen gegevens voltooid! U kunt nu het programma afsluiten.";
                    view.ShowDialog();
                }
                else
                {
                    //If everything is succesfully removed show fail
                    FailedDialogView view = new FailedDialogView();
                    view.Text = "Oeps! Er is iets misgegaan! Probeer het opnieuw!";
                    view.ShowDialog();
                }
                count = 0;
                removed = true;
            }
        }
    }
}
