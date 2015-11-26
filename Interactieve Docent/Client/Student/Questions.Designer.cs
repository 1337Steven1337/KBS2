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
            this.tempBtn = new System.Windows.Forms.Button();
            this.questionTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.chatBoxMessage = new System.Windows.Forms.RichTextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(612, 303);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // tempBtn
            // 
            this.tempBtn.Location = new System.Drawing.Point(0, 375);
            this.tempBtn.Name = "tempBtn";
            this.tempBtn.Size = new System.Drawing.Size(891, 187);
            this.tempBtn.TabIndex = 1;
            this.tempBtn.Text = "Tijdelijke button";
            this.tempBtn.UseVisualStyleBackColor = true;
            // 
            // questionTimeProgressBar
            // 
            this.questionTimeProgressBar.Location = new System.Drawing.Point(0, 315);
            this.questionTimeProgressBar.Maximum = 1000;
            this.questionTimeProgressBar.Name = "questionTimeProgressBar";
            this.questionTimeProgressBar.Size = new System.Drawing.Size(621, 58);
            this.questionTimeProgressBar.Step = 1;
            this.questionTimeProgressBar.TabIndex = 2;
            this.questionTimeProgressBar.Tag = "Time";
            this.questionTimeProgressBar.Value = 1000;
            // 
            // chatBox
            // 
            this.chatBox.ForeColor = System.Drawing.Color.Silver;
            this.chatBox.Location = new System.Drawing.Point(627, 1);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(264, 311);
            this.chatBox.TabIndex = 3;
            this.chatBox.Text = "Je bent nu aangemeld bij de chat\n";
            this.chatBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // chatBoxMessage
            // 
            this.chatBoxMessage.ForeColor = System.Drawing.Color.Silver;
            this.chatBoxMessage.Location = new System.Drawing.Point(627, 315);
            this.chatBoxMessage.Name = "chatBoxMessage";
            this.chatBoxMessage.Size = new System.Drawing.Size(210, 58);
            this.chatBoxMessage.TabIndex = 4;
            this.chatBoxMessage.Text = "Typ een bericht...";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(838, 315);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(67, 54);
            this.sendMessageButton.TabIndex = 5;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(297, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tijd";
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.chatBoxMessage);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.questionTimeProgressBar);
            this.Controls.Add(this.tempBtn);
            this.Controls.Add(this.questionLabel);
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button tempBtn;
        private System.Windows.Forms.ProgressBar questionTimeProgressBar;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.RichTextBox chatBoxMessage;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Label label1;
    }
}