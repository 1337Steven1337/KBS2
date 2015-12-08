using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Dialogs
{
    public partial class FailedDialogView : Form
    {
        public FailedDialogView()
        {
            InitializeComponent();
        }

        public Label getLabelFailed()
        {
            return labelFailed;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
