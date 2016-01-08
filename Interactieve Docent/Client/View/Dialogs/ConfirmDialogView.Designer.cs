namespace Client.View.Dialogs
{
    partial class ConfirmDialogView
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
            this.labelConfirm = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNo = new MetroFramework.Controls.MetroButton();
            this.btnYes = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirm.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelConfirm.Location = new System.Drawing.Point(23, 60);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(95, 20);
            this.labelConfirm.Style = MetroFramework.MetroColorStyle.Black;
            this.labelConfirm.TabIndex = 0;
            this.labelConfirm.Text = "labelConfirm";
            this.labelConfirm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelConfirm.UseCustomBackColor = true;
            this.labelConfirm.UseStyleColors = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnYes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 191);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 35);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNo.Location = new System.Drawing.Point(180, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(171, 29);
            this.btnNo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnNo.TabIndex = 13;
            this.btnNo.Text = "Nee";
            this.btnNo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNo.UseSelectable = true;
            this.btnNo.UseStyleColors = true;
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYes.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnYes.Location = new System.Drawing.Point(3, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(171, 29);
            this.btnYes.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnYes.TabIndex = 12;
            this.btnYes.Text = "Ja";
            this.btnYes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnYes.UseSelectable = true;
            this.btnYes.UseStyleColors = true;
            // 
            // ConfirmDialogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelConfirm);
            this.Movable = false;
            this.Name = "ConfirmDialogView";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Bevestigen";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelConfirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnNo;
        private MetroFramework.Controls.MetroButton btnYes;
    }
}