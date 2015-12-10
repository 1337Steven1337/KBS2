using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Login
{
    public partial class LoginView : Form
    {
        private bool btnLoginClicked = false;

        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLoginClicked = true;
            if(btnLoginClicked)
            {
                
            }
        }
    }
}
