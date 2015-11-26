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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTabs = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Beheren lijsten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 27);
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
            this.button3.Location = new System.Drawing.Point(3, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lijst Openzetten/Sluiten";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(253, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(606, 480);
            this.panel.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelTabs, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(862, 486);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanelTabs
            // 
            this.tableLayoutPanelTabs.ColumnCount = 1;
            this.tableLayoutPanelTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTabs.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanelTabs.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanelTabs.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTabs.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTabs.Name = "tableLayoutPanelTabs";
            this.tableLayoutPanelTabs.RowCount = 3;
            this.tableLayoutPanelTabs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTabs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTabs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTabs.Size = new System.Drawing.Size(244, 480);
            this.tableLayoutPanelTabs.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 486);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelTabs.ResumeLayout(false);
            this.tableLayoutPanelTabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTabs;
    }
}