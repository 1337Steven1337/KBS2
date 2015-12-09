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

namespace Client.View.Authorisation
{
    public partial class AuthorisationView : Form , IView
    {
        private AuthorisationController Controller { get; set; }
        public Boolean valid { private set; get; }

        public AuthorisationView()
        {
            valid = false;
            InitializeComponent();
        }



        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this.Controller = (AuthorisationController)controller;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            valid = true;
            this.Enabled = false;
            Model.Account ac = new Model.Account();
            ac.Password = textBoxPassword.Text;
            ac.Student = textBoxStudent.Text;
            Controller.login(ac);
        }
    }
}
