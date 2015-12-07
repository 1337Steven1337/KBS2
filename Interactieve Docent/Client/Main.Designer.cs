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
            this.tableThreeColls = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableThreeColls
            // 
            this.tableThreeColls.ColumnCount = 3;
            this.tableThreeColls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableThreeColls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableThreeColls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableThreeColls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableThreeColls.Location = new System.Drawing.Point(0, 0);
            this.tableThreeColls.Name = "tableThreeColls";
            this.tableThreeColls.RowCount = 1;
            this.tableThreeColls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableThreeColls.Size = new System.Drawing.Size(862, 486);
            this.tableThreeColls.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 486);
            this.Controls.Add(this.tableThreeColls);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableThreeColls;
    }
}