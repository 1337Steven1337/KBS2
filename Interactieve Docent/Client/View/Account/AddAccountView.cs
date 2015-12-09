using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.Controller.Account;
using Client.View.Dialogs;
using System.Collections.Generic;

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
            InitializeComponent();

            this.SelectExcelFileDialog.FileOk += SelectExcelFileDialog_FileOk;
        }
        #endregion

        #region Events
        private void OpenDialogButton_Click(object sender, EventArgs e)
        {
            this.SelectExcelFileDialog.ShowDialog();
        }

        private void SelectExcelFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                this.Controller.ProcessFile(this.SelectExcelFileDialog.FileName);
            }
        }
        #endregion

        #region Methods
        public void EnableButton()
        {
            this.OpenDialogButton.Enabled = true;
        }

        public void DisableButton()
        {
            this.OpenDialogButton.Enabled = false;
        }

        public void UpdateProgressBar()
        {
            this.SaveProgressBar.PerformStep();
        }

        public void ResetProgressBar(int step, int maxValue)
        {
            this.SaveProgressBar.Maximum = maxValue;
            this.SaveProgressBar.Minimum = 0;
            this.SaveProgressBar.Step = 1;
            this.SaveProgressBar.Value = 0;
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
            return new ControlHandler(this.OpenDialogButton);
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
        #endregion
    }
}
