namespace Client.View.Dialogs
{
    partial class SuccesDialogView
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
            this.labelSucces = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // labelSucces
            // 
            this.labelSucces.AutoSize = true;
            this.labelSucces.BackColor = System.Drawing.Color.Transparent;
            this.labelSucces.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelSucces.Location = new System.Drawing.Point(23, 60);
            this.labelSucces.Name = "labelSucces";
            this.labelSucces.Size = new System.Drawing.Size(81, 20);
            this.labelSucces.Style = MetroFramework.MetroColorStyle.Black;
            this.labelSucces.TabIndex = 0;
            this.labelSucces.Text = "labelFailed";
            this.labelSucces.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelSucces.UseCustomBackColor = true;
            this.labelSucces.UseStyleColors = true;
            // 
            // SuccesDialogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.labelSucces);
            this.Movable = false;
            this.Name = "SuccesDialogView";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Succes";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelSucces;
    }
}