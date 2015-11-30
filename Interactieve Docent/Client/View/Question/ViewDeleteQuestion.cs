using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Question
{
    public partial class ViewDeleteQuestion : Form
    {
        public Boolean valid { get; set; }

        public ViewDeleteQuestion()
        {
            valid = false;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            valid = true;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setText(string text)
        {
            labelNaam.Text = text;
        }
    }
}
