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
            this.tableThreeColumn = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableThreeColumn
            // 
            this.tableThreeColumn.ColumnCount = 3;
            this.tableThreeColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableThreeColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableThreeColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableThreeColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableThreeColumn.Location = new System.Drawing.Point(0, 0);
            this.tableThreeColumn.Name = "tableThreeColumn";
            this.tableThreeColumn.RowCount = 1;
            this.tableThreeColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableThreeColumn.Size = new System.Drawing.Size(282, 253);
            this.tableThreeColumn.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.tableThreeColumn);
            this.Name = "MainView";
            this.Text = "ViewMain2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableThreeColumn;
    }
}