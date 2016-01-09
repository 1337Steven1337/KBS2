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
    public partial class SuccesDialogView : MetroForm
    {
        public SuccesDialogView()
        {
            InitializeComponent();

            this.TopMost = true;
            this.Focus();
            this.BringToFront();
            System.Media.SystemSounds.Beep.Play();
        }

        public Label getLabelSucces()
        {
            return labelSucces;
        }
    }
}
