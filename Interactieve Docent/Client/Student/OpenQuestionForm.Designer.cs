namespace Client.Student
{
    partial class OpenQuestionForm
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
            this.openQuestionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.openQuestionBtn = new System.Windows.Forms.Button();
            this.openQuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.openQuestionLabel = new System.Windows.Forms.Label();
            this.openQuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openQuestionPanel
            // 
            this.openQuestionPanel.ColumnCount = 1;
            this.openQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.openQuestionPanel.Controls.Add(this.openQuestionBtn, 0, 2);
            this.openQuestionPanel.Controls.Add(this.openQuestionTextBox, 0, 1);
            this.openQuestionPanel.Controls.Add(this.openQuestionLabel, 0, 0);
            this.openQuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openQuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.openQuestionPanel.Name = "openQuestionPanel";
            this.openQuestionPanel.RowCount = 3;
            this.openQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.openQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.openQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.openQuestionPanel.Size = new System.Drawing.Size(592, 364);
            this.openQuestionPanel.TabIndex = 0;
            // 
            // openQuestionBtn
            // 
            this.openQuestionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openQuestionBtn.Location = new System.Drawing.Point(3, 293);
            this.openQuestionBtn.Name = "openQuestionBtn";
            this.openQuestionBtn.Size = new System.Drawing.Size(586, 68);
            this.openQuestionBtn.TabIndex = 0;
            this.openQuestionBtn.Text = "Verzenden";
            this.openQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // openQuestionTextBox
            // 
            this.openQuestionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openQuestionTextBox.Location = new System.Drawing.Point(3, 75);
            this.openQuestionTextBox.Name = "openQuestionTextBox";
            this.openQuestionTextBox.Size = new System.Drawing.Size(586, 212);
            this.openQuestionTextBox.TabIndex = 1;
            this.openQuestionTextBox.Tag = "";
            this.openQuestionTextBox.Text = "";
            // 
            // openQuestionLabel
            // 
            this.openQuestionLabel.AutoSize = true;
            this.openQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openQuestionLabel.Location = new System.Drawing.Point(3, 0);
            this.openQuestionLabel.Name = "openQuestionLabel";
            this.openQuestionLabel.Size = new System.Drawing.Size(126, 46);
            this.openQuestionLabel.TabIndex = 2;
            this.openQuestionLabel.Text = "label1";
            // 
            // OpenQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 364);
            this.Controls.Add(this.openQuestionPanel);
            this.Name = "OpenQuestionForm";
            this.Text = "OpenQuestionForm";
            this.openQuestionPanel.ResumeLayout(false);
            this.openQuestionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel openQuestionPanel;
        private System.Windows.Forms.Button openQuestionBtn;
        private System.Windows.Forms.RichTextBox openQuestionTextBox;
        private System.Windows.Forms.Label openQuestionLabel;
    }
}