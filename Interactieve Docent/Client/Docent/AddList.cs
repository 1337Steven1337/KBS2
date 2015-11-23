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
    public partial class AddList : Form
    {
        public string name;
        public Boolean valid = false;
        private TableLayoutPanel mainTable;
        private Label label;
        private Button buttonOk, buttonCancel;
        private TextBox textBox;

        public AddList()
        {
            //Generating Grid Layout setup
            mainTable = new TableLayoutPanel();
            mainTable.Dock = DockStyle.Fill;
            mainTable.ColumnCount = mainTable.RowCount = 2;

            //Top row with label and textBox
            label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text = "Name list:";
            label.Font = new Font("", 12);
            mainTable.Controls.Add(label);

            textBox = new TextBox();
            textBox.Dock = DockStyle.Fill;
            mainTable.Controls.Add(textBox);

            //Bottom row with Ok-button and Cancel-button
            buttonOk = new Button();
            buttonOk.Dock = DockStyle.Fill;
            buttonOk.Text = "Ok";
            buttonOk.Click += buttonOk_Click;
            mainTable.Controls.Add(buttonOk);

            buttonCancel = new Button();
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            mainTable.Controls.Add(buttonCancel);

            Controls.Add(mainTable);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Size = new Size(240,95);
            StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            name = textBox.Text;
                if (name.Count() > 0)
                {
                valid = true;
                this.Close();
                }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
