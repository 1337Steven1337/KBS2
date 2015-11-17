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
            this.labelVraag = new System.Windows.Forms.Label();
            this.labelTijd = new System.Windows.Forms.Label();
            this.labelPunten = new System.Windows.Forms.Label();
            this.vraagVeld = new System.Windows.Forms.RichTextBox();
            this.tijdVeld = new System.Windows.Forms.NumericUpDown();
            this.puntenVeld = new System.Windows.Forms.NumericUpDown();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.tableWrapButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnJa = new System.Windows.Forms.RadioButton();
            this.btnNee = new System.Windows.Forms.RadioButton();
            this.labelAntwoord = new System.Windows.Forms.Label();
            this.tableMainWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tijdVeld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntenVeld)).BeginInit();
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
            this.tableMainWrapper.Controls.Add(this.labelVraag, 0, 0);
            this.tableMainWrapper.Controls.Add(this.labelTijd, 0, 1);
            this.tableMainWrapper.Controls.Add(this.labelPunten, 0, 2);
            this.tableMainWrapper.Controls.Add(this.vraagVeld, 1, 0);
            this.tableMainWrapper.Controls.Add(this.tijdVeld, 1, 1);
            this.tableMainWrapper.Controls.Add(this.puntenVeld, 1, 2);
            this.tableMainWrapper.Controls.Add(this.btnOpslaan, 1, 4);
            this.tableMainWrapper.Controls.Add(this.tableWrapButtons, 1, 3);
            this.tableMainWrapper.Controls.Add(this.labelAntwoord, 0, 3);
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
            // labelVraag
            // 
            this.labelVraag.AutoSize = true;
            this.labelVraag.Location = new System.Drawing.Point(3, 0);
            this.labelVraag.Name = "labelVraag";
            this.labelVraag.Size = new System.Drawing.Size(50, 17);
            this.labelVraag.TabIndex = 8;
            this.labelVraag.Text = "Vraag:";
            // 
            // labelTijd
            // 
            this.labelTijd.AutoSize = true;
            this.labelTijd.Location = new System.Drawing.Point(3, 96);
            this.labelTijd.Name = "labelTijd";
            this.labelTijd.Size = new System.Drawing.Size(152, 17);
            this.labelTijd.TabIndex = 9;
            this.labelTijd.Text = "Tijdslimiet (Seconden):";
            // 
            // labelPunten
            // 
            this.labelPunten.AutoSize = true;
            this.labelPunten.Location = new System.Drawing.Point(3, 192);
            this.labelPunten.Name = "labelPunten";
            this.labelPunten.Size = new System.Drawing.Size(100, 17);
            this.labelPunten.TabIndex = 10;
            this.labelPunten.Text = "Aantal punten:";
            // 
            // vraagVeld
            // 
            this.vraagVeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vraagVeld.Location = new System.Drawing.Point(206, 3);
            this.vraagVeld.Name = "vraagVeld";
            this.vraagVeld.Size = new System.Drawing.Size(469, 90);
            this.vraagVeld.TabIndex = 11;
            this.vraagVeld.Text = "";
            // 
            // tijdVeld
            // 
            this.tijdVeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tijdVeld.Location = new System.Drawing.Point(206, 99);
            this.tijdVeld.Name = "tijdVeld";
            this.tijdVeld.Size = new System.Drawing.Size(469, 22);
            this.tijdVeld.TabIndex = 12;
            // 
            // puntenVeld
            // 
            this.puntenVeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.puntenVeld.Location = new System.Drawing.Point(206, 195);
            this.puntenVeld.Name = "puntenVeld";
            this.puntenVeld.Size = new System.Drawing.Size(469, 22);
            this.puntenVeld.TabIndex = 13;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpslaan.Location = new System.Drawing.Point(206, 387);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(469, 44);
            this.btnOpslaan.TabIndex = 14;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // tableWrapButtons
            // 
            this.tableWrapButtons.ColumnCount = 2;
            this.tableWrapButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWrapButtons.Controls.Add(this.btnJa, 0, 0);
            this.tableWrapButtons.Controls.Add(this.btnNee, 1, 0);
            this.tableWrapButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableWrapButtons.Location = new System.Drawing.Point(206, 291);
            this.tableWrapButtons.Name = "tableWrapButtons";
            this.tableWrapButtons.RowCount = 1;
            this.tableWrapButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableWrapButtons.Size = new System.Drawing.Size(469, 90);
            this.tableWrapButtons.TabIndex = 15;
            // 
            // btnJa
            // 
            this.btnJa.AutoSize = true;
            this.btnJa.Location = new System.Drawing.Point(3, 3);
            this.btnJa.Name = "btnJa";
            this.btnJa.Size = new System.Drawing.Size(44, 21);
            this.btnJa.TabIndex = 0;
            this.btnJa.TabStop = true;
            this.btnJa.Text = "Ja";
            this.btnJa.UseVisualStyleBackColor = true;
            // 
            // btnNee
            // 
            this.btnNee.AutoSize = true;
            this.btnNee.Location = new System.Drawing.Point(237, 3);
            this.btnNee.Name = "btnNee";
            this.btnNee.Size = new System.Drawing.Size(55, 21);
            this.btnNee.TabIndex = 1;
            this.btnNee.TabStop = true;
            this.btnNee.Text = "Nee";
            this.btnNee.UseVisualStyleBackColor = true;
            // 
            // labelAntwoord
            // 
            this.labelAntwoord.AutoSize = true;
            this.labelAntwoord.Location = new System.Drawing.Point(3, 288);
            this.labelAntwoord.Name = "labelAntwoord";
            this.labelAntwoord.Size = new System.Drawing.Size(71, 17);
            this.labelAntwoord.TabIndex = 16;
            this.labelAntwoord.Text = "Antwoord:";
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
            ((System.ComponentModel.ISupportInitialize)(this.tijdVeld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntenVeld)).EndInit();
            this.tableWrapButtons.ResumeLayout(false);
            this.tableWrapButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableMainWrapper;
        private System.Windows.Forms.Label labelVraag;
        private System.Windows.Forms.Label labelTijd;
        private System.Windows.Forms.Label labelPunten;
        private System.Windows.Forms.RichTextBox vraagVeld;
        private System.Windows.Forms.NumericUpDown tijdVeld;
        private System.Windows.Forms.NumericUpDown puntenVeld;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.TableLayoutPanel tableWrapButtons;
        private System.Windows.Forms.Label labelAntwoord;
        private System.Windows.Forms.RadioButton btnJa;
        private System.Windows.Forms.RadioButton btnNee;
    }
}