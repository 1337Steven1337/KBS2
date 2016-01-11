using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Service.Thread;
using System.Net;
using Client.View.Dialogs;
using Client.Model;
using Client.Controller.Account;

namespace Client.View.Account
{
    public partial class AddAccountView : Form, IAddAccountView
    {
        #region Instances
        private AddAccountController Controller { get; set; }
        #endregion

        #region Constructors
        public AddAccountView()
        {
            this.InitializeComponent();
        }
        #endregion

        #region Events
        private void OpenDialogButton_Click(object sender, EventArgs e)
        {
            this.SelectFileDialog.ShowDialog();
        }

        private void SelectExcelFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                this.Controller.ProcessFile(this.SelectFileDialog.FileName);
            }
        }
        #endregion

        #region Methods
        public void EnableButton()
        {
            this.OpenButton.Enabled = true;
        }

        public void DisableButton()
        {
            this.OpenButton.Enabled = false;
        }

        public void UpdateProgressBar()
        {
            this.ShowProgressBar.PerformStep();
        }

        public void ResetProgressBar(int step, int maxValue)
        {
            this.ShowProgressBar.Maximum = maxValue;
            this.ShowProgressBar.Minimum = 0;
            this.ShowProgressBar.Step = 1;
            this.ShowProgressBar.Value = 0;
        }

        public void ShowSaveSucceed()
        {
            SuccesDialogView succes = new SuccesDialogView();
            succes.getLabelSucces().Text = "De e-mails zijn succesvol verzonden.";
            succes.ShowDialog();
        }

        public void ShowLoadFailed()
        {
            FailedDialogView failed = new FailedDialogView();
            failed.getLabelFailed().Text = "Het Excel bestand is ongeldig, er is geen sheet gevonden.";
            failed.ShowDialog();
        }

        public void ShowNoAccountsFound()
        {
            FailedDialogView failed = new FailedDialogView();
            failed.getLabelFailed().Text = "Het Excel bestand is ongeldig, er zijn geen accounts gevonden.";
            failed.ShowDialog();
        }

        public void ShowSaveFailed(Dictionary<string, int> data)
        {
            FailedDialogView failed = new FailedDialogView();
            failed.getLabelFailed().Text = "Kon een of meerdere e-mails niet versturen.";
            failed.ShowDialog();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.OpenButton);
        }

        public void SetController(IController controller)
        {
            this.Controller = (AddAccountController)controller;
        }

        public PredefinedAnswer GetSelectedAnswer()
        {
            throw new NotImplementedException();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void ShowSaveFailed()
        {
            throw new NotImplementedException();
        }

        public void ShowSaveResult(Model.Account instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowUpdateResult(Model.Account instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowDeleteAnswersResult(Model.Account instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ClearAllFields()
        {
            throw new NotImplementedException();
        }
        #endregion

        private void AddAccountView2_Load(object sender, EventArgs e)
        {

        }
    }
}
