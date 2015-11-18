using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.API;

namespace Client
{
    public partial class DocentForm : Form
    {
        public DocentForm()
        {
            InitializeComponent();
            //Form width 80% of the whole screen
            this.Width = Screen.PrimaryScreen.Bounds.Width / 100 * 80;
            //Form height 80% of the whole screen
            this.Height = Screen.PrimaryScreen.Bounds.Height / 100 * 80;
            //Center the Form in the middle of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            //Maintable 50% of the Form
            tableMainWrapper.Width = this.Width / 100 * 50;
            //Main table in the center of the Form
            tableMainWrapper.Location = new Point(this.ClientSize.Width / 2 - tableMainWrapper.Size.Width / 2);
        
            warningLabel.ForeColor = Color.Red;
        }


        //Deze functie wordt nog aan gewerkt!
        public Boolean ValidateEmptyFields()
        {
            if (String.IsNullOrEmpty(vraagVeld.Text))
            {
                return true;
            }
            else if (!btnJa.Checked && !btnNee.Checked)
            {                
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (ValidateEmptyFields())
            {
                warningLabel.Text = "Niet alle velden zijn ingevoerd!";
            }
            else
            {
                warningLabel.Text = "";
            }
        }
    }
}
