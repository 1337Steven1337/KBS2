using System;
using System.Windows.Forms;

namespace Client.View.Question
{
    public partial class DeleteQuestionView : Form
    {
        
        public Boolean valid { get; set; }

        public DeleteQuestionView()
        {
            valid = false;
            InitializeComponent();
        }

        public void buttonOk_Click(object sender, EventArgs e)
        {
            valid = true;
            Close();
        }

        public void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setText(string text)
        {
            labelNaam.Text = text;
        }
    }
}
