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
            this.listBoxQuestionLists = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxQuestionLists
            // 
            this.listBoxQuestionLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuestionLists.FormattingEnabled = true;
            this.listBoxQuestionLists.ItemHeight = 16;
            this.listBoxQuestionLists.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestionLists.Name = "listBoxQuestionLists";
            this.listBoxQuestionLists.Size = new System.Drawing.Size(282, 253);
            this.listBoxQuestionLists.TabIndex = 0;
            // 
            // ViewQuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.listBoxQuestionLists);
            this.Name = "ViewQuestionList";
            this.Text = "ViewQuestionList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuestionLists;
    }
}