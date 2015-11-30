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
    public partial class ViewNewQuestionList : Form
    {
        public string text { set; get; }
        public Boolean valid { set; get; }

        public ViewNewQuestionList()
        {
            valid = false;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length > 0)
            {
                valid = true;
                text = textBox.Text;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
