namespace Client
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.threeColTable = new System.Windows.Forms.TableLayoutPanel();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTabs = new System.Windows.Forms.TableLayoutPanel();
            this.panel.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.tableLayoutPanelTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Beheren lijsten";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Weergeven resultaten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vragen openen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.threeColTable);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(284, 4);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(683, 600);
            this.panel.TabIndex = 3;
            // 
            // threeColTable
            // 
            this.threeColTable.ColumnCount = 3;
            this.threeColTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.threeColTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.threeColTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.threeColTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeColTable.Location = new System.Drawing.Point(0, 0);
            this.threeColTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.threeColTable.Name = "threeColTable";
            this.threeColTable.RowCount = 1;
            this.threeColTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.threeColTable.Size = new System.Drawing.Size(683, 600);
            this.threeColTable.TabIndex = 0;
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.mainTable.Controls.Add(this.tableLayoutPanelTabs, 0, 0);
            this.mainTable.Controls.Add(this.panel, 1, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(970, 608);
            this.mainTable.TabIndex = 4;
            // 
            // tableLayoutPanelTabs
            // 
            this.tableLayoutPanelTabs.ColumnCount = 1;
            this.tableLayoutPanelTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTabs.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanelTabs.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanelTabs.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTabs.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanelTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelTabs.Name = "tableLayoutPanelTabs";
            this.tableLayoutPanelTabs.RowCount = 3;
            this.tableLayoutPanelTabs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTabs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTabs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTabs.Size = new System.Drawing.Size(275, 600);
            this.tableLayoutPanelTabs.TabIndex = 4;
            this.tableLayoutPanelTabs.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTabs_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 608);
            this.Controls.Add(this.mainTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel.ResumeLayout(false);
            this.mainTable.ResumeLayout(false);
            this.tableLayoutPanelTabs.ResumeLayout(false);
            this.tableLayoutPanelTabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTabs;
        private System.Windows.Forms.TableLayoutPanel threeColTable;
    }
}