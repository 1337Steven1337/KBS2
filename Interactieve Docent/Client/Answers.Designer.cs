namespace Client
{
    partial class Answers
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
            this.btn_ShowAnswers = new System.Windows.Forms.Button();
            this.AnswersTextbox = new System.Windows.Forms.RichTextBox();
            this.aantalLabel1 = new System.Windows.Forms.Label();
            this.aantalLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ShowAnswers
            // 
            this.btn_ShowAnswers.Location = new System.Drawing.Point(315, 413);
            this.btn_ShowAnswers.Name = "btn_ShowAnswers";
            this.btn_ShowAnswers.Size = new System.Drawing.Size(88, 38);
            this.btn_ShowAnswers.TabIndex = 1;
            this.btn_ShowAnswers.Text = "button1";
            this.btn_ShowAnswers.UseVisualStyleBackColor = true;
            this.btn_ShowAnswers.Click += new System.EventHandler(this.btn_ShowAnswers_Click);
            // 
            // AnswersTextbox
            // 
            this.AnswersTextbox.Location = new System.Drawing.Point(110, 67);
            this.AnswersTextbox.Name = "AnswersTextbox";
            this.AnswersTextbox.Size = new System.Drawing.Size(293, 292);
            this.AnswersTextbox.TabIndex = 2;
            this.AnswersTextbox.Text = "";
            // 
            // aantalLabel1
            // 
            this.aantalLabel1.AutoSize = true;
            this.aantalLabel1.Location = new System.Drawing.Point(519, 84);
            this.aantalLabel1.Name = "aantalLabel1";
            this.aantalLabel1.Size = new System.Drawing.Size(0, 20);
            this.aantalLabel1.TabIndex = 3;
            // 
            // aantalLabel2
            // 
            this.aantalLabel2.AutoSize = true;
            this.aantalLabel2.Location = new System.Drawing.Point(523, 137);
            this.aantalLabel2.Name = "aantalLabel2";
            this.aantalLabel2.Size = new System.Drawing.Size(0, 20);
            this.aantalLabel2.TabIndex = 4;
            // 
            // Answers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 838);
            this.Controls.Add(this.aantalLabel2);
            this.Controls.Add(this.aantalLabel1);
            this.Controls.Add(this.AnswersTextbox);
            this.Controls.Add(this.btn_ShowAnswers);
            this.Name = "Answers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anwoorden";
            this.Load += new System.EventHandler(this.Anwoorden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ShowAnswers;
        private System.Windows.Forms.RichTextBox AnswersTextbox;
        private System.Windows.Forms.Label aantalLabel1;
        private System.Windows.Forms.Label aantalLabel2;
    }
}