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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(117, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Question";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.listBoxQuestion);
            this.panel.Location = new System.Drawing.Point(27, 76);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 1;
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.ItemHeight = 16;
            this.listBoxQuestion.Location = new System.Drawing.Point(32, 0);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.Size = new System.Drawing.Size(165, 100);
            this.listBoxQuestion.TabIndex = 2;
            // 
            // ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 400);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelTitle);
            this.Name = "ViewQuestion";
            this.Text = "ViewQuestion";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox listBoxQuestion;
    }
}