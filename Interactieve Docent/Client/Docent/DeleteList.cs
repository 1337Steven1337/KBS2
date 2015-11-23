using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Docent
{
    public partial class DeleteList : Form
    {
        public Boolean valid = false;
        private TableLayoutPanel mainTable, bottomTable;
        private Label title;
        private Button buttonOk, buttonCancel;

        public DeleteList()
        {
            mainTable = new TableLayoutPanel();
            mainTable.Dock = DockStyle.Fill;

            //Top row with label and textBox
            title = new Label();
            title.Dock = DockStyle.Fill;
            title.Text = "Weet u zeker dat u de lijst wilt verwijderen?";
            title.Font = new Font("", 12);
            mainTable.Controls.Add(title, 0, 0);

            //Bottom row with Ok-button and Cancel-button
            bottomTable = new TableLayoutPanel();
            bottomTable.Dock = DockStyle.Bottom;

            buttonOk = new Button();
            buttonOk.Dock = DockStyle.Fill;
            buttonOk.Text = "Ok";
            buttonOk.Click += buttonOk_Click;
            bottomTable.Controls.Add(buttonOk,0,0);

            buttonCancel = new Button();
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            bottomTable.Controls.Add(buttonCancel, 1,0);

            bottomTable.Controls.Add(new Label(), 0, 1);         

            mainTable.Controls.Add(bottomTable, 0, 1);
            Controls.Add(mainTable);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Size = new Size(350, 140);
            StartPosition = FormStartPosition.CenterParent;
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
    }
}
