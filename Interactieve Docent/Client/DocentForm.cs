using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class DocentForm : Form
    {
        public DocentForm()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width / 100 * 80;
            this.Height = Screen.PrimaryScreen.Bounds.Height / 100 * 80;
            this.StartPosition = FormStartPosition.CenterScreen;

            contentWrapper.Width = this.Width / 100 * 50;
            contentWrapper.Location = new Point(this.ClientSize.Width / 2 - contentWrapper.Size.Width / 2);

        }
    }
}
