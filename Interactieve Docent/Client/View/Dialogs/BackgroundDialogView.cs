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
    public partial class BackgroundDialogView : Form
    {
        private Form Main { get; set; }

        public BackgroundDialogView()
        {
            InitializeComponent();
        }

        public BackgroundDialogView(Form parent, Form dialog) : this()
        {
            this.Opacity = 0.70;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            this.ClientSize = parent.ClientSize;
            this.Main = parent;

            parent.Move += AdjustPosition;
            parent.SizeChanged += AdjustPosition;

            dialog.FormClosed += Dialog_FormClosed;
            dialog.StartPosition = FormStartPosition.CenterParent;

            this.Show();
            dialog.ShowDialog();
        }

        private void Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Move -= AdjustPosition;
            Main.SizeChanged -= AdjustPosition;
            Main.FormClosed -= Dialog_FormClosed;
            Main.Focus();
            Main.Activate();

            this.Close();
        }

        private void AdjustPosition(object sender, EventArgs e)
        {
            Form parent = sender as Form;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            this.ClientSize = parent.ClientSize;
        }
    }
}
