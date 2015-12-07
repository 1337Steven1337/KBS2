namespace Client.View.QuestionList
{
    partial class ViewQuestionList
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddQuestionList = new System.Windows.Forms.Button();
            this.btnDeleteQuestionList = new System.Windows.Forms.Button();
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
            this.mainTablePanel.Controls.Add(this.buttonsTablePanel, 0, 2);
            this.mainTablePanel.Controls.Add(this.listBoxPanel, 0, 1);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mainTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 3;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTablePanel.Size = new System.Drawing.Size(486, 567);
            this.mainTablePanel.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.labelTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(486, 82);
            this.titlePanel.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(155)))), ((int)(((byte)(153)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(486, 82);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vragenlijsten";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsTablePanel
            // 
            this.buttonsTablePanel.ColumnCount = 2;
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTablePanel.Controls.Add(this.btnAddQuestionList, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.btnDeleteQuestionList, 1, 0);
            this.buttonsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTablePanel.Location = new System.Drawing.Point(0, 517);
            this.buttonsTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTablePanel.Name = "buttonsTablePanel";
            this.buttonsTablePanel.RowCount = 1;
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTablePanel.Size = new System.Drawing.Size(486, 50);
            this.buttonsTablePanel.TabIndex = 0;
            // 
            // btnAddQuestionList
            // 
            this.btnAddQuestionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(155)))), ((int)(((byte)(153)))));
            this.btnAddQuestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddQuestionList.FlatAppearance.BorderSize = 0;
            this.btnAddQuestionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestionList.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestionList.Location = new System.Drawing.Point(0, 0);
            this.btnAddQuestionList.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddQuestionList.Name = "btnAddQuestionList";
            this.btnAddQuestionList.Size = new System.Drawing.Size(243, 50);
            this.btnAddQuestionList.TabIndex = 0;
            this.btnAddQuestionList.Text = "Vragenlijst toevoegen";
            this.btnAddQuestionList.UseVisualStyleBackColor = false;
            // 
            // btnDeleteQuestionList
            // 
            this.btnDeleteQuestionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(155)))), ((int)(((byte)(153)))));
            this.btnDeleteQuestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteQuestionList.FlatAppearance.BorderSize = 0;
            this.btnDeleteQuestionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestionList.ForeColor = System.Drawing.Color.White;
            this.btnDeleteQuestionList.Location = new System.Drawing.Point(243, 0);
            this.btnDeleteQuestionList.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteQuestionList.Name = "btnDeleteQuestionList";
            this.btnDeleteQuestionList.Size = new System.Drawing.Size(243, 50);
            this.btnDeleteQuestionList.TabIndex = 1;
            this.btnDeleteQuestionList.Text = "Vragenlijst verwijderen";
            this.btnDeleteQuestionList.UseVisualStyleBackColor = false;
            // 
            // listBoxPanel
            // 
            this.listBoxPanel.Controls.Add(this.listBoxQuestionLists);
            this.listBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPanel.Location = new System.Drawing.Point(0, 82);
            this.listBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxPanel.Name = "listBoxPanel";
            this.listBoxPanel.Size = new System.Drawing.Size(486, 435);
            this.listBoxPanel.TabIndex = 2;
            // 
            // listBoxQuestionLists
            // 
            this.listBoxQuestionLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxQuestionLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuestionLists.FormattingEnabled = true;
            this.listBoxQuestionLists.ItemHeight = 16;
            this.listBoxQuestionLists.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestionLists.Name = "listBoxQuestionLists";
            this.listBoxQuestionLists.Size = new System.Drawing.Size(486, 435);
            this.listBoxQuestionLists.TabIndex = 0;
            // 
            // ViewQuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 567);
            this.Controls.Add(this.mainTablePanel);
            this.Name = "ViewQuestionList";
            this.Text = "ViewQuestionList";
            this.mainTablePanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.buttonsTablePanel.ResumeLayout(false);
            this.listBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel buttonsTablePanel;
        private System.Windows.Forms.Button btnAddQuestionList;
        private System.Windows.Forms.Button btnDeleteQuestionList;
        private System.Windows.Forms.Panel listBoxPanel;
        private System.Windows.Forms.ListBox listBoxQuestionLists;
    }
}