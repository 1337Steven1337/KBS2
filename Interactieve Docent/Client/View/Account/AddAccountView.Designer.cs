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
            this.OpenButton = new System.Windows.Forms.Button();
            this.ShowProgressBar = new System.Windows.Forms.ProgressBar();
            this.SelectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(161, 13);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // ShowProgressBar
            // 
            this.ShowProgressBar.Location = new System.Drawing.Point(12, 51);
            this.ShowProgressBar.Name = "ShowProgressBar";
            this.ShowProgressBar.Size = new System.Drawing.Size(382, 23);
            this.ShowProgressBar.TabIndex = 1;
            // 
            // SelectFileDialog
            // 
            this.SelectFileDialog.FileName = "openFileDialog1";
            this.SelectFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SelectExcelFileDialog_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteer een Excel bestand:";
            // 
            // AddAccountView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 82);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowProgressBar);
            this.Controls.Add(this.OpenButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccountView2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ProgressBar ShowProgressBar;
        private System.Windows.Forms.OpenFileDialog SelectFileDialog;
        private System.Windows.Forms.Label label1;
    }
}