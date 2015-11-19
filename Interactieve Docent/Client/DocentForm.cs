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

            warningLabel.ForeColor = Color.Red;
            warningLabel.Text = "";
            
        }


        //Check if there are empty fields
        public Boolean ValidateEmptyFields()
        {
            if (String.IsNullOrEmpty(questionField.Text))
            {
                return true;
            }
            else if (!btnYes.Checked && !btnNo.Checked)
            {                
                return true;
            }
            else
            {
                return false;
            }
        }

        //Save question button
        private void btnSave_Click(object sender, EventArgs e)
        {
            List.getAll();
            if (ValidateEmptyFields())
            {
                warningLabel.Text = "Niet alle velden zijn ingevoerd!";
            }
            else
            {
                warningLabel.Text = "";

                String question = questionField.Text;
                int time = (int)timeField.Value;
                bool noAnswer = btnNo.Checked;
                bool yesAnswer = btnYes.Checked;

                List list = new List();
                list.Name = "Toetsvragen Test lijst";
                list.save();

                Question q = new Question();
                q.Text = question;
                q.list = list;
                q.save();

            }
        }
    }
}
