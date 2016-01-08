namespace Client.View.Dialogs
{
    partial class FailedDialogView
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
            this.labelFailed = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // labelFailed
            // 
            this.labelFailed.AutoSize = true;
            this.labelFailed.BackColor = System.Drawing.Color.Transparent;
            this.labelFailed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelFailed.Location = new System.Drawing.Point(23, 60);
            this.labelFailed.Name = "labelFailed";
            this.labelFailed.Size = new System.Drawing.Size(81, 20);
            this.labelFailed.Style = MetroFramework.MetroColorStyle.Black;
            this.labelFailed.TabIndex = 0;
            this.labelFailed.Text = "labelFailed";
            this.labelFailed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelFailed.UseCustomBackColor = true;
            this.labelFailed.UseStyleColors = true;
            // 
            // FailedDialogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.labelFailed);
            this.Movable = false;
            this.Name = "FailedDialogView";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Fout Melding";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelFailed;
    }
}