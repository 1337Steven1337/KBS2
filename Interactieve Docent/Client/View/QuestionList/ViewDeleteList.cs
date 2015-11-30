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
    public partial class ViewDeleteList : Form
    {
        public Boolean valid { get; set; }

        public ViewDeleteList()
        {
            InitializeComponent();
            valid = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            valid = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
