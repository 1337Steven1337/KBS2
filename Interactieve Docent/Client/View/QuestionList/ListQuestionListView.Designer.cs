namespace Client.View.QuestionList
{
    partial class ListQuestionListView
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
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleTile = new MetroFramework.Controls.MetroTile();
            this.buttonsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddQuestionList = new MetroFramework.Controls.MetroButton();
            this.btnDeleteQuestionList = new MetroFramework.Controls.MetroButton();
            this.btnStartQuestionList = new MetroFramework.Controls.MetroButton();
            this.listBoxPanel = new System.Windows.Forms.Panel();
            this.listBoxQuestionLists = new System.Windows.Forms.ListBox();
            this.mainTablePanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.buttonsTablePanel.SuspendLayout();
            this.listBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 1;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Controls.Add(this.titlePanel, 0, 0);
            this.mainTablePanel.Controls.Add(this.buttonsTablePanel, 0, 1);
            this.mainTablePanel.Controls.Add(this.listBoxPanel, 0, 1);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(20, 30);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 3;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTablePanel.Size = new System.Drawing.Size(445, 517);
            this.mainTablePanel.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleTile);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(439, 82);
            this.titlePanel.TabIndex = 1;
            // 
            // titleTile
            // 
            this.titleTile.ActiveControl = null;
            this.titleTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTile.ForeColor = System.Drawing.Color.White;
            this.titleTile.Location = new System.Drawing.Point(0, 0);
            this.titleTile.Name = "titleTile";
            this.titleTile.Size = new System.Drawing.Size(439, 82);
            this.titleTile.TabIndex = 0;
            this.titleTile.Text = "Vragenlijsten";
            this.titleTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.titleTile.UseCustomForeColor = true;
            this.titleTile.UseSelectable = true;
            this.titleTile.UseStyleColors = true;
            this.titleTile.UseTileImage = true;
            // 
            // buttonsTablePanel
            // 
            this.buttonsTablePanel.ColumnCount = 3;
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.Controls.Add(this.btnAddQuestionList, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.btnDeleteQuestionList, 1, 0);
            this.buttonsTablePanel.Controls.Add(this.btnStartQuestionList, 2, 0);
            this.buttonsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTablePanel.Location = new System.Drawing.Point(0, 467);
            this.buttonsTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTablePanel.Name = "buttonsTablePanel";
            this.buttonsTablePanel.RowCount = 1;
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.buttonsTablePanel.Size = new System.Drawing.Size(445, 50);
            this.buttonsTablePanel.TabIndex = 0;
            // 
            // btnAddQuestionList
            // 
            this.btnAddQuestionList.AutoSize = true;
            this.btnAddQuestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddQuestionList.Enabled = false;
            this.btnAddQuestionList.Location = new System.Drawing.Point(3, 3);
            this.btnAddQuestionList.Name = "btnAddQuestionList";
            this.btnAddQuestionList.Size = new System.Drawing.Size(142, 44);
            this.btnAddQuestionList.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAddQuestionList.TabIndex = 3;
            this.btnAddQuestionList.Text = "Vragenlijst toevoegen";
            this.btnAddQuestionList.UseMnemonic = false;
            this.btnAddQuestionList.UseSelectable = true;
            this.btnAddQuestionList.UseStyleColors = true;
            // 
            // btnDeleteQuestionList
            // 
            this.btnDeleteQuestionList.AutoSize = true;
            this.btnDeleteQuestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteQuestionList.Enabled = false;
            this.btnDeleteQuestionList.Location = new System.Drawing.Point(151, 3);
            this.btnDeleteQuestionList.Name = "btnDeleteQuestionList";
            this.btnDeleteQuestionList.Size = new System.Drawing.Size(142, 44);
            this.btnDeleteQuestionList.Style = MetroFramework.MetroColorStyle.Black;
            this.btnDeleteQuestionList.TabIndex = 4;
            this.btnDeleteQuestionList.Text = "Vragenlijst verwijderen";
            this.btnDeleteQuestionList.UseSelectable = true;
            this.btnDeleteQuestionList.UseStyleColors = true;
            // 
            // btnStartQuestionList
            // 
            this.btnStartQuestionList.AutoSize = true;
            this.btnStartQuestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartQuestionList.Enabled = false;
            this.btnStartQuestionList.Location = new System.Drawing.Point(299, 3);
            this.btnStartQuestionList.Name = "btnStartQuestionList";
            this.btnStartQuestionList.Size = new System.Drawing.Size(143, 44);
            this.btnStartQuestionList.Style = MetroFramework.MetroColorStyle.Black;
            this.btnStartQuestionList.TabIndex = 5;
            this.btnStartQuestionList.Text = "Vragenlijst starten";
            this.btnStartQuestionList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStartQuestionList.UseSelectable = true;
            this.btnStartQuestionList.UseStyleColors = true;
            // 
            // listBoxPanel
            // 
            this.listBoxPanel.Controls.Add(this.listBoxQuestionLists);
            this.listBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPanel.Location = new System.Drawing.Point(3, 91);
            this.listBoxPanel.Name = "listBoxPanel";
            this.listBoxPanel.Size = new System.Drawing.Size(439, 373);
            this.listBoxPanel.TabIndex = 2;
            // 
            // listBoxQuestionLists
            // 
            this.listBoxQuestionLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxQuestionLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuestionLists.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuestionLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listBoxQuestionLists.FormattingEnabled = true;
            this.listBoxQuestionLists.ItemHeight = 23;
            this.listBoxQuestionLists.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestionLists.Name = "listBoxQuestionLists";
            this.listBoxQuestionLists.Size = new System.Drawing.Size(439, 373);
            this.listBoxQuestionLists.TabIndex = 0;
            this.listBoxQuestionLists.Tag = "ff";
            // 
            // ListQuestionListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 567);
            this.Controls.Add(this.mainTablePanel);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListQuestionListView";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "ViewQuestionList";
            this.mainTablePanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.buttonsTablePanel.ResumeLayout(false);
            this.buttonsTablePanel.PerformLayout();
            this.listBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTablePanel;
        private System.Windows.Forms.Panel listBoxPanel;
        private System.Windows.Forms.ListBox listBoxQuestionLists;
        private MetroFramework.Controls.MetroButton btnAddQuestionList;
        private MetroFramework.Controls.MetroButton btnDeleteQuestionList;
        private System.Windows.Forms.Panel titlePanel;
        private MetroFramework.Controls.MetroButton btnStartQuestionList;
        private MetroFramework.Controls.MetroTile titleTile;
    }
}