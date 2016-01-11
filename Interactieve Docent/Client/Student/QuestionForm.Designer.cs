namespace Client.Student
{
    partial class QuestionForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.openQuestionBox = new System.Windows.Forms.RichTextBox();
            this.sendOpenQuestionBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.questionCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(18, 14);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(918, 466);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // questionTimeProgressBar
            // 
            this.questionTimeProgressBar.Location = new System.Drawing.Point(0, 485);
            this.questionTimeProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.questionTimeProgressBar.Maximum = 1000;
            this.questionTimeProgressBar.Name = "questionTimeProgressBar";
            this.questionTimeProgressBar.Size = new System.Drawing.Size(932, 89);
            this.questionTimeProgressBar.Step = 1;
            this.questionTimeProgressBar.TabIndex = 2;
            this.questionTimeProgressBar.Tag = "Time";
            this.questionTimeProgressBar.Value = 1000;
            // 
            // openQuestionBox
            // 
            this.openQuestionBox.ForeColor = System.Drawing.Color.Silver;
            this.openQuestionBox.Location = new System.Drawing.Point(989, 14);
            this.openQuestionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openQuestionBox.Name = "openQuestionBox";
            this.openQuestionBox.Size = new System.Drawing.Size(251, 476);
            this.openQuestionBox.TabIndex = 3;
            this.openQuestionBox.Text = "Vul hier je antwoord in.";
            // 
            // sendOpenQuestionBtn
            // 
            this.sendOpenQuestionBtn.Location = new System.Drawing.Point(989, 500);
            this.sendOpenQuestionBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendOpenQuestionBtn.Name = "sendOpenQuestionBtn";
            this.sendOpenQuestionBtn.Size = new System.Drawing.Size(251, 83);
            this.sendOpenQuestionBtn.TabIndex = 5;
            this.sendOpenQuestionBtn.Text = "Verstuur";
            this.sendOpenQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Location = new System.Drawing.Point(446, 511);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 24);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Tijd";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(139, 154);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(647, 58);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Wachten op vraag van de docent..";
            // 
            // questionCountLabel
            // 
            this.questionCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.questionCountLabel.Location = new System.Drawing.Point(806, 452);
            this.questionCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionCountLabel.Name = "questionCountLabel";
            this.questionCountLabel.Size = new System.Drawing.Size(126, 26);
            this.questionCountLabel.TabIndex = 8;
            this.questionCountLabel.Text = "0/0";
            this.questionCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionCountLabel.Visible = false;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 865);
            this.Controls.Add(this.questionCountLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sendOpenQuestionBtn);
            this.Controls.Add(this.openQuestionBox);
            this.Controls.Add(this.questionTimeProgressBar);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ProgressBar questionTimeProgressBar;
        public System.Windows.Forms.RichTextBox openQuestionBox;
        public System.Windows.Forms.Button sendOpenQuestionBtn;
        public System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label questionCountLabel;
    }
}