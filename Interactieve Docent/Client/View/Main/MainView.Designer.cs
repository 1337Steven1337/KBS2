namespace Client.View.Main
{
    partial class MainView
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
            this.tableFourColumn = new System.Windows.Forms.TableLayoutPanel();
            this.ImportAccountButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.tableFourColumn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableFourColumn
            // 
            this.tableFourColumn.ColumnCount = 4;
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableFourColumn.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableFourColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFourColumn.Location = new System.Drawing.Point(0, 0);
            this.tableFourColumn.Name = "tableFourColumn";
            this.tableFourColumn.RowCount = 1;
            this.tableFourColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFourColumn.Size = new System.Drawing.Size(1110, 397);
            this.tableFourColumn.TabIndex = 0;
            // 
            // ImportAccountButton
            // 
            this.ImportAccountButton.AutoSize = true;
            this.ImportAccountButton.BackColor = System.Drawing.Color.White;
            this.ImportAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportAccountButton.Location = new System.Drawing.Point(3, 3);
            this.ImportAccountButton.Name = "ImportAccountButton";
            this.ImportAccountButton.Size = new System.Drawing.Size(99, 55);
            this.ImportAccountButton.TabIndex = 0;
            this.ImportAccountButton.Text = "Import Excel";
            this.ImportAccountButton.UseVisualStyleBackColor = false;
            this.ImportAccountButton.Click += new System.EventHandler(this.ImportAccountButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ImportAccountButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sessionLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(105, 391);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // sessionLabel
            // 
            this.sessionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Location = new System.Drawing.Point(3, 351);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(99, 20);
            this.sessionLabel.TabIndex = 0;
            this.sessionLabel.Text = "SessionID";
            this.sessionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 397);
            this.Controls.Add(this.tableFourColumn);
            this.Name = "MainView";
            this.Text = "ViewMain2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableFourColumn.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableFourColumn;
        private System.Windows.Forms.Button ImportAccountButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label sessionLabel;
    }
}