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
            this.tableFourColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableFourColumn
            // 
            this.tableFourColumn.ColumnCount = 4;
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableFourColumn.Controls.Add(this.ImportAccountButton, 0, 0);
            this.tableFourColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFourColumn.Location = new System.Drawing.Point(0, 0);
            this.tableFourColumn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableFourColumn.Name = "tableFourColumn";
            this.tableFourColumn.RowCount = 1;
            this.tableFourColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFourColumn.Size = new System.Drawing.Size(740, 258);
            this.tableFourColumn.TabIndex = 0;
            // 
            // ImportAccountButton
            // 
            this.ImportAccountButton.AutoSize = true;
            this.ImportAccountButton.BackColor = System.Drawing.Color.White;
            this.ImportAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportAccountButton.Location = new System.Drawing.Point(2, 2);
            this.ImportAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImportAccountButton.Name = "ImportAccountButton";
            this.ImportAccountButton.Size = new System.Drawing.Size(70, 25);
            this.ImportAccountButton.TabIndex = 0;
            this.ImportAccountButton.Text = "Import Excel";
            this.ImportAccountButton.UseVisualStyleBackColor = false;
            this.ImportAccountButton.Click += new System.EventHandler(this.ImportAccountButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 258);
            this.Controls.Add(this.tableFourColumn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainView";
            this.Text = "ViewMain2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableFourColumn.ResumeLayout(false);
            this.tableFourColumn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableFourColumn;
        private System.Windows.Forms.Button ImportAccountButton;
    }
}