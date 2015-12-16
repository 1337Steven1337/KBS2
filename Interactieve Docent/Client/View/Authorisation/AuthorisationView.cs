using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using RestSharp;

namespace Client.View.Authorisation
{
    public partial class AuthorisationView : Form , IAuthorisationView
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            valid = true;
            this.Enabled = false;
            Model.Account acccount = new Model.Account();
            acccount.Password = textBoxPassword.Text;
            acccount.Student = textBoxLogin.Text;
            Controller.CheckAuthorisationResult(acccount);
        }

        public void ShowAuthorisationResult(Model.Account ac, HttpStatusCode status)
        {
            Console.WriteLine(status);
        }
    }
}
