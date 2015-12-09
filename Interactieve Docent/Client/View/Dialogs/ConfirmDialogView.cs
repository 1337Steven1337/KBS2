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
    public partial class ConfirmDialogView : Form
    {
        public Boolean Confirmed { get; set; }

        public ConfirmDialogView()
        {
            this.Confirmed = false;
            InitializeComponent();
        }

        public Label getLabelConfirm()
        {
            return labelConfirm;
        }        
    }
}
