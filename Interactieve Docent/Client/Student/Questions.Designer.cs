namespace Client.Student
{
    partial class Questions
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
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.chatBoxMessage = new System.Windows.Forms.RichTextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
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
            // chatBox
            // 
            this.chatBox.ForeColor = System.Drawing.Color.Silver;
            this.chatBox.Location = new System.Drawing.Point(940, 2);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(394, 476);
            this.chatBox.TabIndex = 3;
            this.chatBox.Text = "Je bent nu aangemeld bij de chat\n";
            this.chatBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // chatBoxMessage
            // 
            this.chatBoxMessage.ForeColor = System.Drawing.Color.Silver;
            this.chatBoxMessage.Location = new System.Drawing.Point(940, 485);
            this.chatBoxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chatBoxMessage.Name = "chatBoxMessage";
            this.chatBoxMessage.Size = new System.Drawing.Size(313, 87);
            this.chatBoxMessage.TabIndex = 4;
            this.chatBoxMessage.Text = "Typ een bericht...";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(1257, 485);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(100, 83);
            this.sendMessageButton.TabIndex = 5;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
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
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 865);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.chatBoxMessage);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.questionTimeProgressBar);
            this.Controls.Add(this.questionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ProgressBar questionTimeProgressBar;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.RichTextBox chatBoxMessage;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Label timeLabel;
    }
}