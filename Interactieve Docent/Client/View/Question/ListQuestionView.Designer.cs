
namespace Client.View.Question
{
    partial class ListQuestionView
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
            this.btnAddQuestion = new MetroFramework.Controls.MetroButton();
            this.btnDeleteQuestion = new MetroFramework.Controls.MetroButton();
            this.btnShowResults = new MetroFramework.Controls.MetroButton();
            this.listBoxPanel = new System.Windows.Forms.Panel();
            this.loadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
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
            this.mainTablePanel.Controls.Add(this.buttonsTablePanel, 0, 2);
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
            this.titlePanel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.titlePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(439, 82);
            this.titlePanel.TabIndex = 1;
            // 
            // titleTile
            // 
            this.titleTile.ActiveControl = null;
            this.titleTile.BackColor = System.Drawing.Color.Orange;
            this.titleTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTile.ForeColor = System.Drawing.Color.White;
            this.titleTile.Location = new System.Drawing.Point(0, 0);
            this.titleTile.Name = "titleTile";
            this.titleTile.Size = new System.Drawing.Size(439, 82);
            this.titleTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.titleTile.TabIndex = 1;
            this.titleTile.Text = "Vragen";
            this.titleTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.titleTile.UseCustomForeColor = true;
            this.titleTile.UseSelectable = true;
            this.titleTile.UseStyleColors = true;
            // 
            // buttonsTablePanel
            // 
            this.buttonsTablePanel.ColumnCount = 3;
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.Controls.Add(this.btnAddQuestion, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.btnDeleteQuestion, 1, 0);
            this.buttonsTablePanel.Controls.Add(this.btnShowResults, 2, 0);
            this.buttonsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTablePanel.Location = new System.Drawing.Point(0, 467);
            this.buttonsTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTablePanel.Name = "buttonsTablePanel";
            this.buttonsTablePanel.RowCount = 1;
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTablePanel.Size = new System.Drawing.Size(445, 50);
            this.buttonsTablePanel.TabIndex = 0;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.AutoSize = true;
            this.btnAddQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddQuestion.Enabled = false;
            this.btnAddQuestion.Location = new System.Drawing.Point(3, 3);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(142, 44);
            this.btnAddQuestion.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddQuestion.TabIndex = 3;
            this.btnAddQuestion.Text = "Vraag toevoegen";
            this.btnAddQuestion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddQuestion.UseSelectable = true;
            this.btnAddQuestion.UseStyleColors = true;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.AutoSize = true;
            this.btnDeleteQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteQuestion.Enabled = false;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(151, 3);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(142, 44);
            this.btnDeleteQuestion.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDeleteQuestion.TabIndex = 5;
            this.btnDeleteQuestion.Text = "Vraag verwijderen";
            this.btnDeleteQuestion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteQuestion.UseSelectable = true;
            this.btnDeleteQuestion.UseStyleColors = true;
            // 
            // btnShowResults
            // 
            this.btnShowResults.AutoSize = true;
            this.btnShowResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowResults.Enabled = false;
            this.btnShowResults.Location = new System.Drawing.Point(299, 3);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(143, 44);
            this.btnShowResults.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnShowResults.TabIndex = 4;
            this.btnShowResults.Text = "Resultaten weergeven";
            this.btnShowResults.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnShowResults.UseSelectable = true;
            this.btnShowResults.UseStyleColors = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // listBoxPanel
            // 
            this.listBoxPanel.Controls.Add(this.loadingSpinner);
            this.listBoxPanel.Controls.Add(this.listBoxQuestions);
            this.listBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPanel.Location = new System.Drawing.Point(3, 91);
            this.listBoxPanel.Name = "listBoxPanel";
            this.listBoxPanel.Size = new System.Drawing.Size(439, 373);
            this.listBoxPanel.TabIndex = 2;
            // 
            // loadingSpinner
            // 
            this.loadingSpinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.loadingSpinner.Location = new System.Drawing.Point(0, 0);
            this.loadingSpinner.Maximum = 100;
            this.loadingSpinner.Name = "loadingSpinner";
            this.loadingSpinner.Size = new System.Drawing.Size(50, 50);
            this.loadingSpinner.Speed = 2F;
            this.loadingSpinner.Style = MetroFramework.MetroColorStyle.Orange;
            this.loadingSpinner.TabIndex = 1;
            this.loadingSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadingSpinner.UseSelectable = true;
            this.loadingSpinner.UseStyleColors = true;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listBoxQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuestions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxQuestions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuestions.ForeColor = System.Drawing.Color.White;
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 23;
            this.listBoxQuestions.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(439, 373);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBoxQuestions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxQuestions_MouseDoubleClick);
            // 
            // ListQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 567);
            this.Controls.Add(this.mainTablePanel);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListQuestionView";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "ViewQuestion";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.mainTablePanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.buttonsTablePanel.ResumeLayout(false);
            this.buttonsTablePanel.PerformLayout();
            this.listBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Panel listBoxPanel;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.TableLayoutPanel buttonsTablePanel;
        private MetroFramework.Controls.MetroButton btnAddQuestion;
        private MetroFramework.Controls.MetroButton btnDeleteQuestion;
        private MetroFramework.Controls.MetroButton btnShowResults;
        private System.Windows.Forms.Panel titlePanel;
        private MetroFramework.Controls.MetroTile titleTile;
        private MetroFramework.Controls.MetroProgressSpinner loadingSpinner;
    }
}