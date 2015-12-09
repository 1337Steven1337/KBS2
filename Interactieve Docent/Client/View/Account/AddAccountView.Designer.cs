namespace Client.View.Account
{
    partial class AddAccountView
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
            this.OpenDialogButton = new System.Windows.Forms.Button();
            this.SelectExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.Location = new System.Drawing.Point(221, 12);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(75, 31);
            this.OpenDialogButton.TabIndex = 0;
            this.OpenDialogButton.Text = "open";
            this.OpenDialogButton.UseVisualStyleBackColor = true;
            this.OpenDialogButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // SelectExcelFileDialog
            // 
            this.SelectExcelFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer uw Excel bestand:";
            // 
            // SaveProgressBar
            // 
            this.SaveProgressBar.Location = new System.Drawing.Point(15, 49);
            this.SaveProgressBar.Name = "SaveProgressBar";
            this.SaveProgressBar.Size = new System.Drawing.Size(281, 23);
            this.SaveProgressBar.TabIndex = 2;
            // 
            // AddAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 84);
            this.Controls.Add(this.SaveProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenDialogButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAccountView";
            this.Load += new System.EventHandler(this.AddAccountView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDialogButton;
        private System.Windows.Forms.OpenFileDialog SelectExcelFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar SaveProgressBar;
    }
}