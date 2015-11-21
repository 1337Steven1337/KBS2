using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class PanelLayout : Panel
    {
        public Form mainForm;
        public Panel panel, middleRow, topRow;
        public Button leftBottomButton, rightBottomButton;
        public Label title;
        public TableLayoutPanel mainTable, bottomRow;

        public PanelLayout(Form mainForm, TableLayoutPanel panelsTable)
        {
            this.mainForm = mainForm;
            //Top row has Panel with a Title.
            title = new Label();
            title.Dock = DockStyle.Fill;
            title.Text = "text..";
            title.Font = new Font("", 16, FontStyle.Underline);
            title.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            title.TextAlign = ContentAlignment.MiddleCenter;

            topRow = new Panel();
            topRow.Dock = DockStyle.Fill;
            topRow.BackColor = ColorTranslator.FromHtml("#002649");
            topRow.Margin = new Padding(0);
            topRow.Controls.Add(title);

            //Middlerow has just a Panel
            middleRow = new Panel();
            middleRow.BackColor = ColorTranslator.FromHtml("#003666");
            middleRow.Dock = DockStyle.Fill;
            middleRow.Margin = new Padding(0);

            //Bottomrow have a table with 2 collums, each of the collumn has a button
            leftBottomButton = new Button();
            leftBottomButton.Text = "text..";
            leftBottomButton.Dock = DockStyle.Fill;
            leftBottomButton.Margin = new Padding(0);

            rightBottomButton = new Button();
            rightBottomButton.Text = "text..";
            rightBottomButton.Dock = DockStyle.Fill;
            rightBottomButton.Margin = new Padding(0);

            bottomRow = new TableLayoutPanel();
            bottomRow.ColumnCount = 2;
            bottomRow.Dock = DockStyle.Fill;
            bottomRow.Margin = new Padding(0);
            bottomRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomRow.Controls.Add(leftBottomButton, 0, 0);
            bottomRow.Controls.Add(rightBottomButton, 1, 0);
        }

        public void updateLayout()
        {
            //Maintable, the table is splitted in 3 rows - TOP ROW 20% / MIDDLE ROW 80% / BOTTOM ROW 10%
            mainTable = new TableLayoutPanel();
            mainTable.ColumnCount = 1;
            mainTable.RowCount = 3;
            mainTable.Dock = DockStyle.Fill;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            mainTable.Controls.Add(topRow, 0, 0);
            mainTable.Controls.Add(middleRow, 0, 1);
            mainTable.Controls.Add(bottomRow, 0, 2);
        }
    }
}
