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
    //Popup which shows when trying to add a new list
    public partial class ViewNewQuestionList : Form
    {
        public string text { set; get; }
        public Boolean valid { set; get; }

        public ViewNewQuestionList()
        {
            //Always assume the user pressed 'New list' on accident
            valid = false;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //Check if textbox is not empty for it is the name of the list
            if(textBox.Text.Length > 0)
            {
                //Confirm the entered name is valid and the user confirmed
                valid = true;
                text = textBox.Text;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Do nothing
            this.Close();
        }
    }
}
