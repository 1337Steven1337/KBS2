namespace Client.View.Diagram
{
    partial class DiagramView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.labelQuestion = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableWrapper = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuestion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelQuestion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(457, 75);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = " Vraag";
            this.labelQuestion.WrapToLine = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 77);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(457, 299);
            this.chart1.TabIndex = 3;
            // 
            // tableWrapper
            // 
            this.tableWrapper.ColumnCount = 1;
            this.tableWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableWrapper.Controls.Add(this.chart1, 0, 1);
            this.tableWrapper.Controls.Add(this.labelQuestion, 0, 0);
            this.tableWrapper.Location = new System.Drawing.Point(23, 33);
            this.tableWrapper.Name = "tableWrapper";
            this.tableWrapper.RowCount = 2;
            this.tableWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableWrapper.Size = new System.Drawing.Size(463, 378);
            this.tableWrapper.TabIndex = 1;
            // 
            // DiagramView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 434);
            this.Controls.Add(this.tableWrapper);
            this.DisplayHeader = false;
            this.Name = "DiagramView";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Diagram";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel labelQuestion;
        private System.Windows.Forms.TableLayoutPanel tableWrapper;
    }
}