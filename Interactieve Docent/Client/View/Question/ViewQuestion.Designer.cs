
namespace Client.View.Question
{
    partial class ViewQuestion
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
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.listBoxPanel = new System.Windows.Forms.Panel();
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
            this.mainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mainTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 3;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTablePanel.Size = new System.Drawing.Size(486, 552);
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
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(129)))), ((int)(((byte)(127)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(486, 82);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vragen";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsTablePanel
            // 
            this.buttonsTablePanel.ColumnCount = 3;
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.Controls.Add(this.btnDeleteQuestion, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.btnAddQuestion, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.btnShowResults, 1, 0);
            this.buttonsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTablePanel.Location = new System.Drawing.Point(0, 502);
            this.buttonsTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTablePanel.Name = "buttonsTablePanel";
            this.buttonsTablePanel.RowCount = 1;
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTablePanel.Size = new System.Drawing.Size(486, 50);
            this.buttonsTablePanel.TabIndex = 0;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(129)))), ((int)(((byte)(127)))));
            this.btnDeleteQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteQuestion.FlatAppearance.BorderSize = 0;
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(162, 0);
            this.btnDeleteQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(162, 50);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "Vraag verwijderen";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(129)))), ((int)(((byte)(127)))));
            this.btnAddQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddQuestion.Enabled = false;
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Location = new System.Drawing.Point(0, 0);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(162, 50);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Vraag toevoegen";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            // 
            // btnShowResults
            // 
            this.btnShowResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(129)))), ((int)(((byte)(127)))));
            this.btnShowResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowResults.FlatAppearance.BorderSize = 0;
            this.btnShowResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResults.ForeColor = System.Drawing.Color.White;
            this.btnShowResults.Location = new System.Drawing.Point(324, 0);
            this.btnShowResults.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(162, 50);
            this.btnShowResults.TabIndex = 1;
            this.btnShowResults.Text = "Resultaat opvragen";
            this.btnShowResults.UseVisualStyleBackColor = false;
            // 
            // listBoxPanel
            // 
            this.listBoxPanel.Controls.Add(this.listBoxQuestions);
            this.listBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPanel.Location = new System.Drawing.Point(0, 82);
            this.listBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxPanel.Name = "listBoxPanel";
            this.listBoxPanel.Size = new System.Drawing.Size(486, 420);
            this.listBoxPanel.TabIndex = 2;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 16;
            this.listBoxQuestions.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(486, 420);
            this.listBoxQuestions.TabIndex = 0;
            // 
            // ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 552);
            this.Controls.Add(this.mainTablePanel);
            this.Name = "ViewQuestion";
            this.Text = "ViewQuestion";
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
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Panel listBoxPanel;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Button btnDeleteQuestion;
    }
}