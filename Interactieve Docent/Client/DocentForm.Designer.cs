namespace Client
{
    partial class DocentForm
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
            this.tableMainWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.questionField = new System.Windows.Forms.RichTextBox();
            this.timeField = new System.Windows.Forms.NumericUpDown();
            this.pointsField = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableWrapButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnYes = new System.Windows.Forms.RadioButton();
            this.btnNo = new System.Windows.Forms.RadioButton();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.tableMainWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsField)).BeginInit();
            this.tableWrapButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMainWrapper
            // 
            this.tableMainWrapper.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableMainWrapper.BackColor = System.Drawing.Color.Transparent;
            this.tableMainWrapper.ColumnCount = 2;
            this.tableMainWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableMainWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableMainWrapper.Controls.Add(this.labelQuestion, 0, 0);
            this.tableMainWrapper.Controls.Add(this.labelTime, 0, 1);
            this.tableMainWrapper.Controls.Add(this.labelPoints, 0, 2);
            this.tableMainWrapper.Controls.Add(this.questionField, 1, 0);
            this.tableMainWrapper.Controls.Add(this.timeField, 1, 1);
            this.tableMainWrapper.Controls.Add(this.pointsField, 1, 2);
            this.tableMainWrapper.Controls.Add(this.btnSave, 1, 4);
            this.tableMainWrapper.Controls.Add(this.tableWrapButtons, 1, 3);
            this.tableMainWrapper.Controls.Add(this.labelAnswer, 0, 3);
            this.tableMainWrapper.Controls.Add(this.warningLabel, 0, 4);
            this.tableMainWrapper.Location = new System.Drawing.Point(0, 0);
            this.tableMainWrapper.Name = "tableMainWrapper";
            this.tableMainWrapper.RowCount = 5;
            this.tableMainWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMainWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMainWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMainWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMainWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMainWrapper.Size = new System.Drawing.Size(678, 434);
            this.tableMainWrapper.TabIndex = 2;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(50, 17);
            this.labelQuestion.TabIndex = 8;
            this.labelQuestion.Text = "Vraag:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(3, 96);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(152, 17);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Tijdslimiet (Seconden):";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(3, 192);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(100, 17);
            this.labelPoints.TabIndex = 10;
            this.labelPoints.Text = "Aantal punten:";
            // 
            // questionField
            // 
            this.questionField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionField.Location = new System.Drawing.Point(206, 3);
            this.questionField.Name = "questionField";
            this.questionField.Size = new System.Drawing.Size(469, 90);
            this.questionField.TabIndex = 11;
            this.questionField.Text = "";
            // 
            // timeField
            // 
            this.timeField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeField.Location = new System.Drawing.Point(206, 99);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(469, 22);
            this.timeField.TabIndex = 12;
            // 
            // pointsField
            // 
            this.pointsField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsField.Location = new System.Drawing.Point(206, 195);
            this.pointsField.Name = "pointsField";
            this.pointsField.Size = new System.Drawing.Size(469, 22);
            this.pointsField.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(206, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(469, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // tableWrapButtons
            // 
            this.tableWrapButtons.ColumnCount = 2;
            this.tableWrapButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapButtons.Controls.Add(this.btnYes, 0, 0);
            this.tableWrapButtons.Controls.Add(this.btnNo, 1, 0);
            this.tableWrapButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableWrapButtons.Location = new System.Drawing.Point(206, 291);
            this.tableWrapButtons.Name = "tableWrapButtons";
            this.tableWrapButtons.RowCount = 1;
            this.tableWrapButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableWrapButtons.Size = new System.Drawing.Size(469, 90);
            this.tableWrapButtons.TabIndex = 15;
            // 
            // btnYes
            // 
            this.btnYes.AutoSize = true;
            this.btnYes.Location = new System.Drawing.Point(3, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(44, 21);
            this.btnYes.TabIndex = 0;
            this.btnYes.TabStop = true;
            this.btnYes.Text = "Ja";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.AutoSize = true;
            this.btnNo.Location = new System.Drawing.Point(237, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(55, 21);
            this.btnNo.TabIndex = 1;
            this.btnNo.TabStop = true;
            this.btnNo.Text = "Nee";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(3, 288);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(71, 17);
            this.labelAnswer.TabIndex = 16;
            this.labelAnswer.Text = "Antwoord:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(3, 384);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 17);
            this.warningLabel.TabIndex = 17;
            // 
            // DocentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 434);
            this.Controls.Add(this.tableMainWrapper);
            this.Name = "DocentForm";
            this.Text = "DocentForm";
            this.tableMainWrapper.ResumeLayout(false);
            this.tableMainWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsField)).EndInit();
            this.tableWrapButtons.ResumeLayout(false);
            this.tableWrapButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableMainWrapper;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.RichTextBox questionField;
        private System.Windows.Forms.NumericUpDown timeField;
        private System.Windows.Forms.NumericUpDown pointsField;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TableLayoutPanel tableWrapButtons;
        private System.Windows.Forms.RadioButton btnYes;
        private System.Windows.Forms.RadioButton btnNo;
        private System.Windows.Forms.Label warningLabel;
    }
}