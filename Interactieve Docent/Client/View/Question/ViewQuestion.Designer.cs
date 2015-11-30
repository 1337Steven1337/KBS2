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
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.ItemHeight = 16;
            this.listBoxQuestion.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.Size = new System.Drawing.Size(338, 400);
            this.listBoxQuestion.TabIndex = 2;
            // 
            // ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 400);
            this.Controls.Add(this.listBoxQuestion);
            this.Name = "ViewQuestion";
            this.Text = "ViewQuestion";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxQuestion;
    }
}