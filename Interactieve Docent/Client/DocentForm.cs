using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class DocentForm : Form
    {
        private int vraagnummer;
        private List<List<object>> vragen;
        public DocentForm()
            
        {
            vragen = new List<List<object>>();
            vraagnummer = 1;
            
            InitializeComponent();
            labelVraag.Text = "Vraag 1:";
            //Form width 80% of the whole screen
            this.Width = Screen.PrimaryScreen.Bounds.Width / 100 * 80;
            //Form height 80% of the whole screen
            this.Height = Screen.PrimaryScreen.Bounds.Height / 100 * 80;
            //Center the Form in the middle of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            //Maintable 50% of the Form
            tableMainWrapper.Width = this.Width / 100 * 50;
            //Main table in the center of the Form
            tableMainWrapper.Location = new Point(this.ClientSize.Width / 2 - tableMainWrapper.Size.Width / 2, 50);

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

        public void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (ValidateEmptyFields())
            {
                warningLabel.Text = "Niet alle velden zijn ingevoerd!";
            }
            else
            {
                List<object> vraag = new List<object>();
                vraag.Add(vraagVeld.Text);
                vraag.Add(tijdVeld.Value);
                vraag.Add(puntenVeld.Value);
                if (btnJa.Checked){ vraag.Add(1);}
                else { vraag.Add(0);}
                vragen.Add(vraag);

                vraagnummer++;
                vraagVeld.Text = "";
                btnJa.Checked = false;
                btnNee.Checked = false;
                labelVraag.Text = "Vraag " + vraagnummer + ":";
                warningLabel.Text = "";
                
                Opslaan();
            }
        }

        public void Opslaan()
        {
            //Upload vraag naar server
            //try - catch voor het opslaan
        }

        private void DocentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
