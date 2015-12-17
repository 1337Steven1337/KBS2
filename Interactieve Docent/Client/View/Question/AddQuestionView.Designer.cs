﻿namespace Client.View.Question
{
    partial class AddQuestionView
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
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuestionField = new System.Windows.Forms.Label();
            this.questionField = new System.Windows.Forms.RichTextBox();
            this.labelTimeField = new System.Windows.Forms.Label();
            this.labelPointsField = new System.Windows.Forms.Label();
            this.labelAnswerField = new System.Windows.Forms.Label();
            this.answerField = new System.Windows.Forms.TextBox();
            this.timeField = new System.Windows.Forms.NumericUpDown();
            this.pointsField = new System.Windows.Forms.NumericUpDown();
            this.answersListBox = new System.Windows.Forms.ListBox();
            this.labelAnswersListBox = new System.Windows.Forms.Label();
            this.rightAnswerComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnDeleteAnswer = new System.Windows.Forms.Button();
            this.labelRightAnswer = new System.Windows.Forms.Label();
            this.mainTablePanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.buttonsTablePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsField)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 1;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Controls.Add(this.titlePanel, 0, 0);
            this.mainTablePanel.Controls.Add(this.buttonsTablePanel, 0, 2);
            this.mainTablePanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mainTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 3;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.mainTablePanel.Size = new System.Drawing.Size(1188, 896);
            this.mainTablePanel.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.labelTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1188, 129);
            this.titlePanel.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1188, 129);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vraag toevoegen";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsTablePanel
            // 
            this.buttonsTablePanel.ColumnCount = 2;
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.Controls.Add(this.btnSaveQuestion, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.btnQuit, 1, 0);
            this.buttonsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTablePanel.Location = new System.Drawing.Point(0, 817);
            this.buttonsTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTablePanel.Name = "buttonsTablePanel";
            this.buttonsTablePanel.RowCount = 1;
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.buttonsTablePanel.Size = new System.Drawing.Size(1188, 79);
            this.buttonsTablePanel.TabIndex = 0;
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnSaveQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveQuestion.FlatAppearance.BorderSize = 0;
            this.btnSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestion.ForeColor = System.Drawing.Color.White;
            this.btnSaveQuestion.Location = new System.Drawing.Point(0, 0);
            this.btnSaveQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(594, 79);
            this.btnSaveQuestion.TabIndex = 9;
            this.btnSaveQuestion.Text = "Opslaan";
            this.btnSaveQuestion.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(594, 0);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(594, 79);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Sluiten";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.labelQuestionField, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.questionField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTimeField, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPointsField, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAnswerField, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.answerField, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.timeField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pointsField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.answersListBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelAnswersListBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rightAnswerComboBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAddAnswer, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteAnswer, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelRightAnswer, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 133);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 680);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelQuestionField
            // 
            this.labelQuestionField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestionField.AutoSize = true;
            this.labelQuestionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionField.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelQuestionField.Location = new System.Drawing.Point(4, 0);
            this.labelQuestionField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionField.Name = "labelQuestionField";
            this.labelQuestionField.Size = new System.Drawing.Size(208, 79);
            this.labelQuestionField.TabIndex = 0;
            this.labelQuestionField.Text = "Vraag*";
            this.labelQuestionField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // questionField
            // 
            this.questionField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionField.Location = new System.Drawing.Point(220, 4);
            this.questionField.Margin = new System.Windows.Forms.Padding(4);
            this.questionField.Name = "questionField";
            this.questionField.Size = new System.Drawing.Size(666, 71);
            this.questionField.TabIndex = 1;
            this.questionField.Text = "";
            // 
            // labelTimeField
            // 
            this.labelTimeField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeField.AutoSize = true;
            this.labelTimeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeField.Location = new System.Drawing.Point(4, 79);
            this.labelTimeField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeField.Name = "labelTimeField";
            this.labelTimeField.Size = new System.Drawing.Size(208, 39);
            this.labelTimeField.TabIndex = 2;
            this.labelTimeField.Text = "Tijd (sec)*";
            this.labelTimeField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPointsField
            // 
            this.labelPointsField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPointsField.AutoSize = true;
            this.labelPointsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsField.Location = new System.Drawing.Point(4, 118);
            this.labelPointsField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPointsField.Name = "labelPointsField";
            this.labelPointsField.Size = new System.Drawing.Size(208, 39);
            this.labelPointsField.TabIndex = 3;
            this.labelPointsField.Text = "Punten*";
            this.labelPointsField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAnswerField
            // 
            this.labelAnswerField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswerField.AutoSize = true;
            this.labelAnswerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerField.Location = new System.Drawing.Point(4, 157);
            this.labelAnswerField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswerField.Name = "labelAnswerField";
            this.labelAnswerField.Size = new System.Drawing.Size(208, 75);
            this.labelAnswerField.TabIndex = 9;
            this.labelAnswerField.Text = "Antwoord invoeren";
            this.labelAnswerField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // answerField
            // 
            this.answerField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerField.Location = new System.Drawing.Point(220, 161);
            this.answerField.Margin = new System.Windows.Forms.Padding(4);
            this.answerField.Multiline = true;
            this.answerField.Name = "answerField";
            this.answerField.Size = new System.Drawing.Size(666, 67);
            this.answerField.TabIndex = 4;
            // 
            // timeField
            // 
            this.timeField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeField.Location = new System.Drawing.Point(220, 83);
            this.timeField.Margin = new System.Windows.Forms.Padding(4);
            this.timeField.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(666, 31);
            this.timeField.TabIndex = 2;
            this.timeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pointsField
            // 
            this.pointsField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsField.Location = new System.Drawing.Point(220, 122);
            this.pointsField.Margin = new System.Windows.Forms.Padding(4);
            this.pointsField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pointsField.Name = "pointsField";
            this.pointsField.Size = new System.Drawing.Size(666, 31);
            this.pointsField.TabIndex = 3;
            this.pointsField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // answersListBox
            // 
            this.answersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answersListBox.FormattingEnabled = true;
            this.answersListBox.ItemHeight = 25;
            this.answersListBox.Location = new System.Drawing.Point(220, 236);
            this.answersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.answersListBox.Name = "answersListBox";
            this.answersListBox.Size = new System.Drawing.Size(666, 323);
            this.answersListBox.TabIndex = 6;
            // 
            // labelAnswersListBox
            // 
            this.labelAnswersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswersListBox.AutoSize = true;
            this.labelAnswersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswersListBox.Location = new System.Drawing.Point(4, 232);
            this.labelAnswersListBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswersListBox.Name = "labelAnswersListBox";
            this.labelAnswersListBox.Size = new System.Drawing.Size(208, 331);
            this.labelAnswersListBox.TabIndex = 4;
            this.labelAnswersListBox.Text = "Antwoorden*";
            this.labelAnswersListBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rightAnswerComboBox
            // 
            this.rightAnswerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightAnswerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightAnswerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAnswerComboBox.FormattingEnabled = true;
            this.rightAnswerComboBox.Location = new System.Drawing.Point(220, 567);
            this.rightAnswerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.rightAnswerComboBox.Name = "rightAnswerComboBox";
            this.rightAnswerComboBox.Size = new System.Drawing.Size(666, 33);
            this.rightAnswerComboBox.TabIndex = 8;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnswer.AutoSize = true;
            this.btnAddAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnAddAnswer.FlatAppearance.BorderSize = 0;
            this.btnAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAddAnswer.Location = new System.Drawing.Point(894, 161);
            this.btnAddAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(282, 67);
            this.btnAddAnswer.TabIndex = 5;
            this.btnAddAnswer.Text = "Toevoegen";
            this.btnAddAnswer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAnswer.AutoSize = true;
            this.btnDeleteAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(103)))), ((int)(((byte)(100)))));
            this.btnDeleteAnswer.FlatAppearance.BorderSize = 0;
            this.btnDeleteAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAnswer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAnswer.Location = new System.Drawing.Point(894, 236);
            this.btnDeleteAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(282, 67);
            this.btnDeleteAnswer.TabIndex = 7;
            this.btnDeleteAnswer.Text = "Verwijder";
            this.btnDeleteAnswer.UseVisualStyleBackColor = false;
            // 
            // labelRightAnswer
            // 
            this.labelRightAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRightAnswer.AutoSize = true;
            this.labelRightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightAnswer.Location = new System.Drawing.Point(4, 563);
            this.labelRightAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRightAnswer.Name = "labelRightAnswer";
            this.labelRightAnswer.Size = new System.Drawing.Size(208, 117);
            this.labelRightAnswer.TabIndex = 14;
            this.labelRightAnswer.Text = "Juiste antwoord*";
            this.labelRightAnswer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 896);
            this.Controls.Add(this.mainTablePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuestionView";
            this.Text = "ViewAddQuestion";
            this.Load += new System.EventHandler(this.AddQuestionView_Load);
            this.mainTablePanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.buttonsTablePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel buttonsTablePanel;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTimeField;
        private System.Windows.Forms.Label labelPointsField;
        private System.Windows.Forms.Label labelAnswersListBox;
        private System.Windows.Forms.ListBox answersListBox;
        private System.Windows.Forms.NumericUpDown timeField;
        private System.Windows.Forms.NumericUpDown pointsField;
        private System.Windows.Forms.Label labelAnswerField;
        private System.Windows.Forms.Button btnDeleteAnswer;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.TextBox answerField;
        private System.Windows.Forms.Label labelQuestionField;
        private System.Windows.Forms.RichTextBox questionField;
        private System.Windows.Forms.ComboBox rightAnswerComboBox;
        private System.Windows.Forms.Label labelRightAnswer;
    }
}