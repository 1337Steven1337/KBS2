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
            this.SelectExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectExcelFileDialog
            // 
            this.SelectExcelFileDialog.FileName = "openFileDialog1";
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.Location = new System.Drawing.Point(116, 65);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(75, 23);
            this.OpenDialogButton.TabIndex = 0;
            this.OpenDialogButton.Text = "button1";
            this.OpenDialogButton.UseVisualStyleBackColor = true;
            this.OpenDialogButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // AddAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 177);
            this.Controls.Add(this.OpenDialogButton);
            this.Name = "AddAccountView";
            this.Text = "AddAccountView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SelectExcelFileDialog;
        private System.Windows.Forms.Button OpenDialogButton;
    }
}