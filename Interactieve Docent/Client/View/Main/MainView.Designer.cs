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
            this.tableLeftButtons = new System.Windows.Forms.TableLayoutPanel();
            this.SessionLabel = new MetroFramework.Controls.MetroLabel();
            this.EndSessionButton = new MetroFramework.Controls.MetroTile();
            this.ResultOpenQuestionButton = new MetroFramework.Controls.MetroButton();
            this.EndSession = new MetroFramework.Controls.MetroButton();
            this.ImportAccountButton = new MetroFramework.Controls.MetroButton();
            this.OpenQuestionButton = new MetroFramework.Controls.MetroButton();
            this.tableFourColumn.SuspendLayout();
            this.tableLeftButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableFourColumn
            // 
            this.tableFourColumn.ColumnCount = 4;
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableFourColumn.Controls.Add(this.tableLeftButtons, 0, 0);
            this.tableFourColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFourColumn.Location = new System.Drawing.Point(20, 30);
            this.tableFourColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableFourColumn.Name = "tableFourColumn";
            this.tableFourColumn.RowCount = 1;
            this.tableFourColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFourColumn.Size = new System.Drawing.Size(588, 268);
            this.tableFourColumn.TabIndex = 0;
            // 
            // tableLeftButtons
            // 
            this.tableLeftButtons.ColumnCount = 1;
            this.tableLeftButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeftButtons.Controls.Add(this.SessionLabel, 0, 4);
            this.tableLeftButtons.Controls.Add(this.ResultOpenQuestionButton, 0, 2);
            this.tableLeftButtons.Controls.Add(this.EndSession, 0, 3);
            this.tableLeftButtons.Controls.Add(this.ImportAccountButton, 0, 0);
            this.tableLeftButtons.Controls.Add(this.OpenQuestionButton, 0, 1);
            this.tableLeftButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLeftButtons.Location = new System.Drawing.Point(3, 3);
            this.tableLeftButtons.Name = "tableLeftButtons";
            this.tableLeftButtons.RowCount = 5;
            this.tableLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLeftButtons.Size = new System.Drawing.Size(52, 262);
            this.tableLeftButtons.TabIndex = 1;
            // 
            // SessionLabel
            // 
            this.SessionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SessionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SessionLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SessionLabel.Location = new System.Drawing.Point(3, 237);
            this.SessionLabel.Name = "SessionLabel";
            this.SessionLabel.Size = new System.Drawing.Size(46, 25);
            this.SessionLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.SessionLabel.TabIndex = 4;
            this.SessionLabel.Text = "Sessie";
            this.SessionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SessionLabel.UseStyleColors = true;
            // 
            // EndSessionButton
            // 
            this.EndSessionButton.ActiveControl = null;
            this.EndSessionButton.BackColor = System.Drawing.Color.White;
            this.EndSessionButton.Location = new System.Drawing.Point(3, 69);
            this.EndSessionButton.Name = "EndSessionButton";
            this.EndSessionButton.Size = new System.Drawing.Size(84, 49);
            this.EndSessionButton.TabIndex = 3;
            this.EndSessionButton.Text = "Sessie Eindigen";
            this.EndSessionButton.UseSelectable = true;
            this.EndSessionButton.Click += new System.EventHandler(this.EndSessionButton_Click);
            // 
            // ResultOpenQuestionButton
            // 
            this.ResultOpenQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.ResultOpenQuestionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultOpenQuestionButton.Location = new System.Drawing.Point(3, 118);
            this.ResultOpenQuestionButton.Name = "ResultOpenQuestionButton";
            this.ResultOpenQuestionButton.Size = new System.Drawing.Size(46, 49);
            this.ResultOpenQuestionButton.Style = MetroFramework.MetroColorStyle.White;
            this.ResultOpenQuestionButton.TabIndex = 5;
            this.ResultOpenQuestionButton.Text = "Resultaten open vraag";
            this.ResultOpenQuestionButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResultOpenQuestionButton.UseCustomBackColor = true;
            this.ResultOpenQuestionButton.UseSelectable = true;
            this.ResultOpenQuestionButton.UseStyleColors = true;
            // 
            // EndSession
            // 
            this.EndSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.EndSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndSession.Location = new System.Drawing.Point(3, 173);
            this.EndSession.Name = "EndSession";
            this.EndSession.Size = new System.Drawing.Size(46, 49);
            this.EndSession.Style = MetroFramework.MetroColorStyle.White;
            this.EndSession.TabIndex = 6;
            this.EndSession.Text = "Sessie eindigen";
            this.EndSession.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EndSession.UseCustomBackColor = true;
            this.EndSession.UseSelectable = true;
            this.EndSession.UseStyleColors = true;
            // 
            // ImportAccountButton
            // 
            this.ImportAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.ImportAccountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportAccountButton.Location = new System.Drawing.Point(3, 3);
            this.ImportAccountButton.Name = "ImportAccountButton";
            this.ImportAccountButton.Size = new System.Drawing.Size(46, 54);
            this.ImportAccountButton.Style = MetroFramework.MetroColorStyle.White;
            this.ImportAccountButton.TabIndex = 7;
            this.ImportAccountButton.Text = "Accounts importeren";
            this.ImportAccountButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ImportAccountButton.UseCustomBackColor = true;
            this.ImportAccountButton.UseSelectable = true;
            this.ImportAccountButton.UseStyleColors = true;
            this.ImportAccountButton.Click += new System.EventHandler(this.ImportAccountButton_Click);
            // 
            // OpenQuestionButton
            // 
            this.OpenQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.OpenQuestionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenQuestionButton.Location = new System.Drawing.Point(3, 63);
            this.OpenQuestionButton.Name = "OpenQuestionButton";
            this.OpenQuestionButton.Size = new System.Drawing.Size(46, 49);
            this.OpenQuestionButton.Style = MetroFramework.MetroColorStyle.White;
            this.OpenQuestionButton.TabIndex = 8;
            this.OpenQuestionButton.Text = "Open vraag toevoegen";
            this.OpenQuestionButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenQuestionButton.UseCustomBackColor = true;
            this.OpenQuestionButton.UseSelectable = true;
            this.OpenQuestionButton.UseStyleColors = true;
            this.OpenQuestionButton.Click += new System.EventHandler(this.OpenQuestionButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(628, 318);
            this.Controls.Add(this.tableFourColumn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainView";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "ViewMain2";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tableFourColumn.ResumeLayout(false);
            this.tableLeftButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableFourColumn;
        private System.Windows.Forms.TableLayoutPanel tableLeftButtons;
        private MetroFramework.Controls.MetroTile EndSessionButton;
        private MetroFramework.Controls.MetroLabel SessionLabel;
        private MetroFramework.Controls.MetroButton ResultOpenQuestionButton;
        private MetroFramework.Controls.MetroButton EndSession;
        private MetroFramework.Controls.MetroButton ImportAccountButton;
        private MetroFramework.Controls.MetroButton OpenQuestionButton;
    }
}