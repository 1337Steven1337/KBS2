using System;
using System.Windows.Forms;
using Client.Controller;
using Client.Service.Thread;
using Client.Controller.Main;

namespace Client.View.Main
{
    public partial class StartView : Form, IView
    {
        private ShowStartController Controller;

        public StartView()
        {
            InitializeComponent();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.CodeTextBox);
        }

        public void SetController(IController controller)
        {
            this.Controller = (ShowStartController)controller;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(this.CodeTextBox.Text != null && this.CodeTextBox.Text.Length == 6)
            {
                Controller.CheckCode(this.CodeTextBox.Text);
            }
        }
    }
}
