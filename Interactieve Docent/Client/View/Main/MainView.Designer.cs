namespace Client.View.Main
{
    partial class MainView
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
            this.tableFourColumn = new System.Windows.Forms.TableLayoutPanel();
            this.ImportAccountButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenQuestionButton = new System.Windows.Forms.Button();
            this.tableFourColumn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableFourColumn
            // 
            this.tableFourColumn.ColumnCount = 4;
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableFourColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableFourColumn.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableFourColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFourColumn.Location = new System.Drawing.Point(0, 0);
            this.tableFourColumn.Margin = new System.Windows.Forms.Padding(2);
            this.tableFourColumn.Name = "tableFourColumn";
            this.tableFourColumn.RowCount = 1;
            this.tableFourColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFourColumn.Size = new System.Drawing.Size(740, 258);
            this.tableFourColumn.TabIndex = 0;
            // 
            // ImportAccountButton
            // 
            this.ImportAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportAccountButton.AutoSize = true;
            this.ImportAccountButton.BackColor = System.Drawing.Color.White;
            this.ImportAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportAccountButton.Location = new System.Drawing.Point(2, 2);
            this.ImportAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImportAccountButton.Name = "ImportAccountButton";
            this.ImportAccountButton.Size = new System.Drawing.Size(64, 25);
            this.ImportAccountButton.TabIndex = 0;
            this.ImportAccountButton.Text = "Import Excel";
            this.ImportAccountButton.UseVisualStyleBackColor = false;
            this.ImportAccountButton.Click += new System.EventHandler(this.ImportAccountButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OpenQuestionButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ImportAccountButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(68, 252);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // OpenQuestionButton
            // 
            this.OpenQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenQuestionButton.AutoSize = true;
            this.OpenQuestionButton.BackColor = System.Drawing.Color.White;
            this.OpenQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenQuestionButton.Location = new System.Drawing.Point(2, 32);
            this.OpenQuestionButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenQuestionButton.Name = "OpenQuestionButton";
            this.OpenQuestionButton.Size = new System.Drawing.Size(64, 25);
            this.OpenQuestionButton.TabIndex = 1;
            this.OpenQuestionButton.Text = "Open vraag";
            this.OpenQuestionButton.UseVisualStyleBackColor = false;
            this.OpenQuestionButton.Click += new System.EventHandler(this.OpenQuestionButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 258);
            this.Controls.Add(this.tableFourColumn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "ViewMain2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableFourColumn.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableFourColumn;
        private System.Windows.Forms.Button ImportAccountButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OpenQuestionButton;
    }
}