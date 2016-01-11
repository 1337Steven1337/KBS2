namespace Client.View.Teacher
{
    partial class TeacherEnvironmentView
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
            this.QuestionsListBox = new System.Windows.Forms.ListBox();
            this.tableWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.tableLeft = new System.Windows.Forms.TableLayoutPanel();
            this.OpenDialogButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tableWrapper.SuspendLayout();
            this.tableLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionsListBox
            // 
            this.QuestionsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.QuestionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionsListBox.Enabled = false;
            this.QuestionsListBox.FormattingEnabled = true;
            this.QuestionsListBox.ItemHeight = 16;
            this.QuestionsListBox.Location = new System.Drawing.Point(3, 210);
            this.QuestionsListBox.Name = "QuestionsListBox";
            this.QuestionsListBox.Size = new System.Drawing.Size(268, 118);
            this.QuestionsListBox.TabIndex = 2;
            // 
            // tableWrapper
            // 
            this.tableWrapper.ColumnCount = 2;
            this.tableWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapper.Controls.Add(this.tableLeft, 0, 0);
            this.tableWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableWrapper.Location = new System.Drawing.Point(20, 60);
            this.tableWrapper.Name = "tableWrapper";
            this.tableWrapper.RowCount = 1;
            this.tableWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableWrapper.Size = new System.Drawing.Size(560, 420);
            this.tableWrapper.TabIndex = 1;
            // 
            // tableLeft
            // 
            this.tableLeft.ColumnCount = 1;
            this.tableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeft.Controls.Add(this.QuestionsListBox, 0, 1);
            this.tableLeft.Controls.Add(this.OpenDialogButton, 0, 2);
            this.tableLeft.Controls.Add(this.metroButton1, 0, 3);
            this.tableLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLeft.Name = "tableLeft";
            this.tableLeft.RowCount = 4;
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLeft.Size = new System.Drawing.Size(274, 414);
            this.tableLeft.TabIndex = 0;
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenDialogButton.Location = new System.Drawing.Point(3, 334);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(268, 35);
            this.OpenDialogButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.OpenDialogButton.TabIndex = 3;
            this.OpenDialogButton.Text = "Volgende vraag";
            this.OpenDialogButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenDialogButton.UseSelectable = true;
            this.OpenDialogButton.UseStyleColors = true;
            this.OpenDialogButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton1.Location = new System.Drawing.Point(3, 375);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(268, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Vragenlijst stoppen";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.QuitQuestionList_Click);
            // 
            // TeacherEnvironmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.tableWrapper);
            this.Name = "TeacherEnvironmentView";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "TeacherEnvironmentView";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.tableWrapper.ResumeLayout(false);
            this.tableLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox QuestionsListBox;
        private System.Windows.Forms.TableLayoutPanel tableWrapper;
        private System.Windows.Forms.TableLayoutPanel tableLeft;
        private MetroFramework.Controls.MetroButton OpenDialogButton;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}