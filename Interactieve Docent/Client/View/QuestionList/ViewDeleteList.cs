using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.QuestionList
{
    //Popup which shows when trying to delete a list
    public partial class ViewDeleteList : Form
    { 
        public Boolean valid { get; set; }

        public ViewDeleteList()
        {
            InitializeComponent();
            //Always assume the user pressed 'Delete list' on accident
            valid = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //Confirming the user wants to delete the list
            valid = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Do nothing
            this.Close();
        }

        public void setText(string text)
        {
            //Shows the name of the 'list-to-be-deleted'
            labelNaam.Text = text;
        }
    }
}
