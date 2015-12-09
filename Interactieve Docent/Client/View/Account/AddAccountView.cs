using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.Controller.Account;
using Client.View.Dialogs;

namespace Client.View.Account
{
    public partial class AddAccountView : Form, IAddAccountView
    {
        private Button OpenDialogButton;
        private OpenFileDialog SelectExcelFileDialog;

        private AddAccountController Controller { get; set; }

        public AddAccountView()
        {
            InitializeComponent();

            this.SelectExcelFileDialog.FileOk += SelectExcelFileDialog_FileOk;
        }

        private void SelectExcelFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if(!e.Cancel)
            {
                this.Controller.ProcessFile(this.SelectExcelFileDialog.FileName);
            }
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.OpenDialogButton);
        }

        public PredefinedAnswer GetSelectedAnswer()
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this.Controller = (AddAccountController)controller;
        }

        public void ShowSaveFailed()
        {
            throw new NotImplementedException();
        }

        public void ShowSaveResult(Model.Account instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowSaveSucceed()
        {
            throw new NotImplementedException();
        }

        private void OpenDialogButton_Click(object sender, EventArgs e)
        {
            this.SelectExcelFileDialog.ShowDialog();

        }

        public void ShowLoadFailed()
        {
            FailedDialogView failed = new FailedDialogView();
            failed.getLabelFailed().Text = "Het Excel bestand is ongeldig, er is geen sheet gevonden.";
            failed.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SelectExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectExcelFileDialog
            // 
            this.SelectExcelFileDialog.FileName = "openFileDialog1";
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.Location = new System.Drawing.Point(137, 66);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(75, 23);
            this.OpenDialogButton.TabIndex = 0;
            this.OpenDialogButton.Text = "button1";
            this.OpenDialogButton.UseVisualStyleBackColor = true;
            // 
            // AddAccountView
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OpenDialogButton);
            this.Name = "AddAccountView";
            this.ResumeLayout(false);

        }
    }
}
