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
            this.tijdVeld = new System.Windows.Forms.NumericUpDown();
            this.puntenVeld = new System.Windows.Forms.NumericUpDown();
            this.labelTijd = new System.Windows.Forms.Label();
            this.labelPunten = new System.Windows.Forms.Label();
            this.inputVraag = new System.Windows.Forms.RichTextBox();
            this.labelVraag = new System.Windows.Forms.Label();
            this.contentWrapper = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tijdVeld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntenVeld)).BeginInit();
            this.contentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // tijdVeld
            // 
            this.tijdVeld.Location = new System.Drawing.Point(146, 69);
            this.tijdVeld.Name = "tijdVeld";
            this.tijdVeld.Size = new System.Drawing.Size(186, 22);
            this.tijdVeld.TabIndex = 5;
            // 
            // puntenVeld
            // 
            this.puntenVeld.Location = new System.Drawing.Point(146, 36);
            this.puntenVeld.Name = "puntenVeld";
            this.puntenVeld.Size = new System.Drawing.Size(186, 22);
            this.puntenVeld.TabIndex = 4;
            // 
            // labelTijd
            // 
            this.labelTijd.AutoSize = true;
            this.labelTijd.Location = new System.Drawing.Point(3, 66);
            this.labelTijd.Name = "labelTijd";
            this.labelTijd.Size = new System.Drawing.Size(80, 34);
            this.labelTijd.TabIndex = 3;
            this.labelTijd.Text = "Tijdslimiet (seconden)";
            // 
            // labelPunten
            // 
            this.labelPunten.AutoSize = true;
            this.labelPunten.Location = new System.Drawing.Point(3, 33);
            this.labelPunten.Name = "labelPunten";
            this.labelPunten.Size = new System.Drawing.Size(125, 17);
            this.labelPunten.TabIndex = 2;
            this.labelPunten.Text = "Punten voor vraag";
            // 
            // inputVraag
            // 
            this.inputVraag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputVraag.Location = new System.Drawing.Point(146, 3);
            this.inputVraag.Name = "inputVraag";
            this.inputVraag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputVraag.Size = new System.Drawing.Size(186, 27);
            this.inputVraag.TabIndex = 1;
            this.inputVraag.Text = "";
            // 
            // labelVraag
            // 
            this.labelVraag.AutoSize = true;
            this.labelVraag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVraag.Location = new System.Drawing.Point(3, 0);
            this.labelVraag.Name = "labelVraag";
            this.labelVraag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelVraag.Size = new System.Drawing.Size(46, 17);
            this.labelVraag.TabIndex = 0;
            this.labelVraag.Text = "Vraag";
            // 
            // contentWrapper
            // 
            this.contentWrapper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentWrapper.ColumnCount = 2;
            this.contentWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.contentWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.contentWrapper.Controls.Add(this.tijdVeld, 1, 2);
            this.contentWrapper.Controls.Add(this.labelVraag, 0, 0);
            this.contentWrapper.Controls.Add(this.labelTijd, 0, 2);
            this.contentWrapper.Controls.Add(this.puntenVeld, 1, 1);
            this.contentWrapper.Controls.Add(this.inputVraag, 1, 0);
            this.contentWrapper.Controls.Add(this.labelPunten, 0, 1);
            this.contentWrapper.Location = new System.Drawing.Point(163, 12);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.RowCount = 3;
            this.contentWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.contentWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.contentWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.contentWrapper.Size = new System.Drawing.Size(335, 100);
            this.contentWrapper.TabIndex = 2;
            // 
            // DocentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 434);
            this.Controls.Add(this.contentWrapper);
            this.Name = "DocentForm";
            this.Text = "DocentForm";
            ((System.ComponentModel.ISupportInitialize)(this.tijdVeld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntenVeld)).EndInit();
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox inputVraag;
        private System.Windows.Forms.Label labelVraag;
        private System.Windows.Forms.NumericUpDown tijdVeld;
        private System.Windows.Forms.NumericUpDown puntenVeld;
        private System.Windows.Forms.Label labelTijd;
        private System.Windows.Forms.Label labelPunten;
        private System.Windows.Forms.TableLayoutPanel contentWrapper;
    }
}