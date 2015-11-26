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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsField)).BeginInit();
            this.tableWrapButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.BackColor = System.Drawing.Color.Transparent;
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableMain.Controls.Add(this.labelQuestion, 0, 0);
            this.tableMain.Controls.Add(this.labelTime, 0, 1);
            this.tableMain.Controls.Add(this.labelPoints, 0, 2);
            this.tableMain.Controls.Add(this.questionField, 1, 0);
            this.tableMain.Controls.Add(this.timeField, 1, 1);
            this.tableMain.Controls.Add(this.pointsField, 1, 2);
            this.tableMain.Controls.Add(this.btnSave, 1, 4);
            this.tableMain.Controls.Add(this.tableWrapButtons, 1, 3);
            this.tableMain.Controls.Add(this.labelAnswer, 0, 3);
            this.tableMain.Controls.Add(this.warningLabel, 0, 4);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 5;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.Size = new System.Drawing.Size(854, 356);
            this.tableMain.TabIndex = 2;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(192, 0);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(62, 20);
            this.labelQuestion.TabIndex = 8;
            this.labelQuestion.Text = "Vraag:";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(63, 79);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(191, 20);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Tijdslimiet (Seconden):";
            // 
            // labelPoints
            // 
            this.labelPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(127, 158);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(127, 20);
            this.labelPoints.TabIndex = 10;
            this.labelPoints.Text = "Aantal punten:";
            // 
            // questionField
            // 
            this.questionField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionField.Location = new System.Drawing.Point(258, 3);
            this.questionField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.questionField.Name = "questionField";
            this.questionField.Size = new System.Drawing.Size(594, 73);
            this.questionField.TabIndex = 11;
            this.questionField.Text = "";
            // 
            // timeField
            // 
            this.timeField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeField.Location = new System.Drawing.Point(258, 82);
            this.timeField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(594, 20);
            this.timeField.TabIndex = 12;
            // 
            // pointsField
            // 
            this.pointsField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsField.Location = new System.Drawing.Point(258, 161);
            this.pointsField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pointsField.Name = "pointsField";
            this.pointsField.Size = new System.Drawing.Size(594, 20);
            this.pointsField.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(258, 319);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(594, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableWrapButtons
            // 
            this.tableWrapButtons.ColumnCount = 2;
            this.tableWrapButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapButtons.Controls.Add(this.btnYes, 0, 0);
            this.tableWrapButtons.Controls.Add(this.btnNo, 1, 0);
            this.tableWrapButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableWrapButtons.Location = new System.Drawing.Point(258, 240);
            this.tableWrapButtons.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableWrapButtons.Name = "tableWrapButtons";
            this.tableWrapButtons.RowCount = 1;
            this.tableWrapButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableWrapButtons.Size = new System.Drawing.Size(594, 73);
            this.tableWrapButtons.TabIndex = 15;
            // 
            // btnYes
            // 
            this.btnYes.AutoSize = true;
            this.btnYes.Location = new System.Drawing.Point(2, 3);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(36, 17);
            this.btnYes.TabIndex = 0;
            this.btnYes.TabStop = true;
            this.btnYes.Text = "Ja";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.AutoSize = true;
            this.btnNo.Location = new System.Drawing.Point(299, 3);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(45, 17);
            this.btnNo.TabIndex = 1;
            this.btnNo.TabStop = true;
            this.btnNo.Text = "Nee";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // labelAnswer
            // 
            this.labelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(164, 237);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(90, 20);
            this.labelAnswer.TabIndex = 16;
            this.labelAnswer.Text = "Antwoord:";
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.Location = new System.Drawing.Point(172, 316);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(82, 13);
            this.warningLabel.TabIndex = 17;
            this.warningLabel.Text = "warningLabel";
            // 
            // DocentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 356);
            this.Controls.Add(this.tableMain);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DocentForm";
            this.Text = "DocentForm";
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsField)).EndInit();
            this.tableWrapButtons.ResumeLayout(false);
            this.tableWrapButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableMain;
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