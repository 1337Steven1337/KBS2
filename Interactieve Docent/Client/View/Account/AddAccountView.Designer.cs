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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.SaveProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.table2Col = new System.Windows.Forms.TableLayoutPanel();
            this.label = new MetroFramework.Controls.MetroLabel();
            this.OpenDialogButton = new MetroFramework.Controls.MetroButton();
            this.tableMain.SuspendLayout();
            this.table2Col.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectExcelFileDialog
            // 
            this.SelectExcelFileDialog.FileName = "openFileDialog1";
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.SaveProgressBar, 0, 1);
            this.tableMain.Controls.Add(this.table2Col, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(27, 74);
            this.tableMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Size = new System.Drawing.Size(523, 98);
            this.tableMain.TabIndex = 2;
            // 
            // SaveProgressBar
            // 
            this.SaveProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveProgressBar.Location = new System.Drawing.Point(3, 52);
            this.SaveProgressBar.Name = "SaveProgressBar";
            this.SaveProgressBar.Size = new System.Drawing.Size(517, 43);
            this.SaveProgressBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.SaveProgressBar.TabIndex = 4;
            this.SaveProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // table2Col
            // 
            this.table2Col.ColumnCount = 2;
            this.table2Col.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table2Col.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table2Col.Controls.Add(this.label, 0, 0);
            this.table2Col.Controls.Add(this.OpenDialogButton, 1, 0);
            this.table2Col.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table2Col.Location = new System.Drawing.Point(3, 3);
            this.table2Col.Name = "table2Col";
            this.table2Col.RowCount = 1;
            this.table2Col.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table2Col.Size = new System.Drawing.Size(517, 43);
            this.table2Col.TabIndex = 5;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.CausesValidation = false;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(64, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(191, 20);
            this.label.Style = MetroFramework.MetroColorStyle.Black;
            this.label.TabIndex = 0;
            this.label.Text = "Selecteer een excel bestand: ";
            this.label.UseCustomBackColor = true;
            this.label.UseStyleColors = true;
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpenDialogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenDialogButton.Location = new System.Drawing.Point(261, 3);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(253, 37);
            this.OpenDialogButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.OpenDialogButton.TabIndex = 1;
            this.OpenDialogButton.Text = "Open Excelbestand";
            this.OpenDialogButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenDialogButton.UseSelectable = true;
            this.OpenDialogButton.UseStyleColors = true;
            this.OpenDialogButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // AddAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 197);
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Movable = false;
            this.Name = "AddAccountView";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Accounts toevoegen";
            this.tableMain.ResumeLayout(false);
            this.table2Col.ResumeLayout(false);
            this.table2Col.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog SelectExcelFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private MetroFramework.Controls.MetroProgressBar SaveProgressBar;
        private System.Windows.Forms.TableLayoutPanel table2Col;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroButton OpenDialogButton;
    }
}