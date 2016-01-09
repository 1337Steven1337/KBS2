using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Client.View.Dialogs
{
    public partial class ConfirmDialogView : MetroForm
    {
        public ConfirmDialogView()
        {
            InitializeComponent();

            this.TopMost = true;
            this.Focus();
            this.BringToFront();
            System.Media.SystemSounds.Beep.Play();
        }

        public Label getLabelConfirm()
        {
            return labelConfirm;
        }
    }
}
