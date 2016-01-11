namespace Client.View.Question
{
    partial class AddQuestionView
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
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleTile = new MetroFramework.Controls.MetroTile();
            this.buttonsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuit = new MetroFramework.Controls.MetroButton();
            this.btnSaveQuestion = new MetroFramework.Controls.MetroButton();
            this.tableInputFields = new System.Windows.Forms.TableLayoutPanel();
            this.answersListBox = new System.Windows.Forms.ListBox();
            this.timeField = new System.Windows.Forms.NumericUpDown();
            this.tableRadioButtons = new System.Windows.Forms.TableLayoutPanel();
            this.rbNoTime = new MetroFramework.Controls.MetroRadioButton();
            this.rbSetTime = new MetroFramework.Controls.MetroRadioButton();
            this.labelQuestionField = new MetroFramework.Controls.MetroLabel();
            this.questionField = new MetroFramework.Controls.MetroTextBox();
            this.labelTimeField = new MetroFramework.Controls.MetroLabel();
            this.labelAnswerField = new MetroFramework.Controls.MetroLabel();
            this.labelAnswersListBox = new MetroFramework.Controls.MetroLabel();
            this.labelRightAnswer = new MetroFramework.Controls.MetroLabel();
            this.rightAnswerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.btnAddAnswer = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAnswer = new MetroFramework.Controls.MetroButton();
            this.answerField = new MetroFramework.Controls.MetroTextBox();
            this.mainTablePanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.buttonsTablePanel.SuspendLayout();
            this.tableInputFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).BeginInit();
            this.tableRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 1;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.Controls.Add(this.titlePanel, 0, 0);
            this.mainTablePanel.Controls.Add(this.buttonsTablePanel, 0, 2);
            this.mainTablePanel.Controls.Add(this.tableInputFields, 0, 1);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(22, 38);
            this.mainTablePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 3;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.mainTablePanel.Size = new System.Drawing.Size(847, 759);
            this.mainTablePanel.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleTile);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(3, 4);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(841, 102);
            this.titlePanel.TabIndex = 1;
            // 
            // titleTile
            // 
            this.titleTile.ActiveControl = null;
            this.titleTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTile.ForeColor = System.Drawing.Color.White;
            this.titleTile.Location = new System.Drawing.Point(0, 0);
            this.titleTile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTile.Name = "titleTile";
            this.titleTile.Size = new System.Drawing.Size(841, 102);
            this.titleTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.titleTile.TabIndex = 1;
            this.titleTile.Text = "Vraag toevoegen";
            this.titleTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.titleTile.UseCustomForeColor = true;
            this.titleTile.UseSelectable = true;
            this.titleTile.UseStyleColors = true;
            // 
            // buttonsTablePanel
            // 
            this.buttonsTablePanel.ColumnCount = 2;
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTablePanel.Controls.Add(this.btnQuit, 0, 0);
            this.buttonsTablePanel.Controls.Add(this.btnSaveQuestion, 0, 0);
            this.buttonsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTablePanel.Location = new System.Drawing.Point(0, 697);
            this.buttonsTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTablePanel.Name = "buttonsTablePanel";
            this.buttonsTablePanel.RowCount = 1;
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.buttonsTablePanel.Size = new System.Drawing.Size(847, 62);
            this.buttonsTablePanel.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.Location = new System.Drawing.Point(426, 4);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(418, 54);
            this.btnQuit.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Sluiten";
            this.btnQuit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnQuit.UseSelectable = true;
            this.btnQuit.UseStyleColors = true;
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveQuestion.Location = new System.Drawing.Point(3, 4);
            this.btnSaveQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(417, 54);
            this.btnSaveQuestion.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSaveQuestion.TabIndex = 11;
            this.btnSaveQuestion.Text = "Opslaan";
            this.btnSaveQuestion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSaveQuestion.UseSelectable = true;
            this.btnSaveQuestion.UseStyleColors = true;
            // 
            // tableInputFields
            // 
            this.tableInputFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tableInputFields.ColumnCount = 3;
            this.tableInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableInputFields.Controls.Add(this.answersListBox, 1, 4);
            this.tableInputFields.Controls.Add(this.timeField, 1, 2);
            this.tableInputFields.Controls.Add(this.tableRadioButtons, 1, 1);
            this.tableInputFields.Controls.Add(this.labelQuestionField, 0, 0);
            this.tableInputFields.Controls.Add(this.questionField, 1, 0);
            this.tableInputFields.Controls.Add(this.labelTimeField, 0, 2);
            this.tableInputFields.Controls.Add(this.labelAnswerField, 0, 3);
            this.tableInputFields.Controls.Add(this.labelAnswersListBox, 0, 4);
            this.tableInputFields.Controls.Add(this.labelRightAnswer, 0, 5);
            this.tableInputFields.Controls.Add(this.rightAnswerComboBox, 1, 5);
            this.tableInputFields.Controls.Add(this.btnAddAnswer, 2, 3);
            this.tableInputFields.Controls.Add(this.btnDeleteAnswer, 2, 4);
            this.tableInputFields.Controls.Add(this.answerField, 1, 3);
            this.tableInputFields.Location = new System.Drawing.Point(3, 114);
            this.tableInputFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableInputFields.Name = "tableInputFields";
            this.tableInputFields.RowCount = 6;
            this.tableInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableInputFields.Size = new System.Drawing.Size(839, 579);
            this.tableInputFields.TabIndex = 2;
            // 
            // answersListBox
            // 
            this.answersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.answersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answersListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.answersListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answersListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.answersListBox.FormattingEnabled = true;
            this.answersListBox.ItemHeight = 23;
            this.answersListBox.Location = new System.Drawing.Point(136, 209);
            this.answersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answersListBox.Name = "answersListBox";
            this.answersListBox.Size = new System.Drawing.Size(488, 245);
            this.answersListBox.TabIndex = 6;
            this.answersListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            // 
            // timeField
            // 
            this.timeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.timeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeField.ForeColor = System.Drawing.Color.Black;
            this.timeField.Location = new System.Drawing.Point(136, 128);
            this.timeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeField.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(488, 31);
            this.timeField.TabIndex = 2;
            this.timeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeField.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tableRadioButtons
            // 
            this.tableRadioButtons.ColumnCount = 2;
            this.tableRadioButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableRadioButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableRadioButtons.Controls.Add(this.rbNoTime, 1, 0);
            this.tableRadioButtons.Controls.Add(this.rbSetTime, 0, 0);
            this.tableRadioButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRadioButtons.Location = new System.Drawing.Point(136, 86);
            this.tableRadioButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableRadioButtons.Name = "tableRadioButtons";
            this.tableRadioButtons.RowCount = 1;
            this.tableRadioButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableRadioButtons.Size = new System.Drawing.Size(488, 36);
            this.tableRadioButtons.TabIndex = 15;
            // 
            // rbNoTime
            // 
            this.rbNoTime.AutoSize = true;
            this.rbNoTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbNoTime.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbNoTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rbNoTime.Location = new System.Drawing.Point(247, 4);
            this.rbNoTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNoTime.Name = "rbNoTime";
            this.rbNoTime.Size = new System.Drawing.Size(238, 28);
            this.rbNoTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.rbNoTime.TabIndex = 19;
            this.rbNoTime.Text = "Geen Tijdslimiet";
            this.rbNoTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbNoTime.UseCustomForeColor = true;
            this.rbNoTime.UseSelectable = true;
            this.rbNoTime.UseStyleColors = true;
            this.rbNoTime.CheckedChanged += new System.EventHandler(this.rbNoTime_CheckedChanged);
            // 
            // rbSetTime
            // 
            this.rbSetTime.AutoSize = true;
            this.rbSetTime.Checked = true;
            this.rbSetTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSetTime.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbSetTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rbSetTime.Location = new System.Drawing.Point(3, 4);
            this.rbSetTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSetTime.Name = "rbSetTime";
            this.rbSetTime.Size = new System.Drawing.Size(238, 28);
            this.rbSetTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.rbSetTime.TabIndex = 18;
            this.rbSetTime.TabStop = true;
            this.rbSetTime.Text = "Tijdslimiet instellen";
            this.rbSetTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbSetTime.UseCustomForeColor = true;
            this.rbSetTime.UseSelectable = true;
            this.rbSetTime.UseStyleColors = true;
            // 
            // labelQuestionField
            // 
            this.labelQuestionField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestionField.AutoSize = true;
            this.labelQuestionField.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionField.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelQuestionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.labelQuestionField.Location = new System.Drawing.Point(3, 0);
            this.labelQuestionField.Name = "labelQuestionField";
            this.labelQuestionField.Size = new System.Drawing.Size(127, 82);
            this.labelQuestionField.TabIndex = 16;
            this.labelQuestionField.Text = "Vraag*";
            this.labelQuestionField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelQuestionField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelQuestionField.UseCustomBackColor = true;
            // 
            // questionField
            // 
            this.questionField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            this.questionField.CustomButton.Image = null;
            this.questionField.CustomButton.Location = new System.Drawing.Point(416, 2);
            this.questionField.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionField.CustomButton.Name = "";
            this.questionField.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.questionField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.questionField.CustomButton.TabIndex = 1;
            this.questionField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.questionField.CustomButton.UseSelectable = true;
            this.questionField.CustomButton.Visible = false;
            this.questionField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.questionField.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.questionField.ForeColor = System.Drawing.Color.Black;
            this.questionField.Lines = new string[0];
            this.questionField.Location = new System.Drawing.Point(136, 4);
            this.questionField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionField.MaxLength = 32767;
            this.questionField.Multiline = true;
            this.questionField.Name = "questionField";
            this.questionField.PasswordChar = '\0';
            this.questionField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.questionField.SelectedText = "";
            this.questionField.SelectionLength = 0;
            this.questionField.SelectionStart = 0;
            this.questionField.Size = new System.Drawing.Size(488, 74);
            this.questionField.TabIndex = 17;
            this.questionField.UseCustomBackColor = true;
            this.questionField.UseCustomForeColor = true;
            this.questionField.UseSelectable = true;
            this.questionField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.questionField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelTimeField
            // 
            this.labelTimeField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeField.AutoSize = true;
            this.labelTimeField.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTimeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.labelTimeField.Location = new System.Drawing.Point(3, 126);
            this.labelTimeField.Name = "labelTimeField";
            this.labelTimeField.Size = new System.Drawing.Size(127, 35);
            this.labelTimeField.TabIndex = 18;
            this.labelTimeField.Text = "Tijdslimiet (sec)*";
            this.labelTimeField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelTimeField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelTimeField.UseCustomBackColor = true;
            // 
            // labelAnswerField
            // 
            this.labelAnswerField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswerField.AutoSize = true;
            this.labelAnswerField.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelAnswerField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.labelAnswerField.Location = new System.Drawing.Point(3, 161);
            this.labelAnswerField.Name = "labelAnswerField";
            this.labelAnswerField.Size = new System.Drawing.Size(127, 46);
            this.labelAnswerField.TabIndex = 19;
            this.labelAnswerField.Text = "Antwoord invoeren";
            this.labelAnswerField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelAnswerField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelAnswerField.UseCustomBackColor = true;
            // 
            // labelAnswersListBox
            // 
            this.labelAnswersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswersListBox.AutoSize = true;
            this.labelAnswersListBox.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelAnswersListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.labelAnswersListBox.Location = new System.Drawing.Point(3, 207);
            this.labelAnswersListBox.Name = "labelAnswersListBox";
            this.labelAnswersListBox.Size = new System.Drawing.Size(127, 249);
            this.labelAnswersListBox.TabIndex = 20;
            this.labelAnswersListBox.Text = "Antwoorden";
            this.labelAnswersListBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelAnswersListBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelAnswersListBox.UseCustomBackColor = true;
            // 
            // labelRightAnswer
            // 
            this.labelRightAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRightAnswer.AutoSize = true;
            this.labelRightAnswer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelRightAnswer.Location = new System.Drawing.Point(3, 456);
            this.labelRightAnswer.Name = "labelRightAnswer";
            this.labelRightAnswer.Size = new System.Drawing.Size(127, 123);
            this.labelRightAnswer.TabIndex = 21;
            this.labelRightAnswer.Text = "Juiste antwoord*";
            this.labelRightAnswer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelRightAnswer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelRightAnswer.UseCustomBackColor = true;
            // 
            // rightAnswerComboBox
            // 
            this.rightAnswerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rightAnswerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightAnswerComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.rightAnswerComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.rightAnswerComboBox.ForeColor = System.Drawing.Color.White;
            this.rightAnswerComboBox.FormattingEnabled = true;
            this.rightAnswerComboBox.ItemHeight = 29;
            this.rightAnswerComboBox.Location = new System.Drawing.Point(136, 460);
            this.rightAnswerComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightAnswerComboBox.Name = "rightAnswerComboBox";
            this.rightAnswerComboBox.Size = new System.Drawing.Size(488, 35);
            this.rightAnswerComboBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.rightAnswerComboBox.TabIndex = 22;
            this.rightAnswerComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rightAnswerComboBox.UseSelectable = true;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnswer.Location = new System.Drawing.Point(630, 165);
            this.btnAddAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(206, 38);
            this.btnAddAnswer.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddAnswer.TabIndex = 23;
            this.btnAddAnswer.Text = "Antwoord toevoegen";
            this.btnAddAnswer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddAnswer.UseSelectable = true;
            this.btnAddAnswer.UseStyleColors = true;
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.Location = new System.Drawing.Point(630, 211);
            this.btnDeleteAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(198, 38);
            this.btnDeleteAnswer.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDeleteAnswer.TabIndex = 24;
            this.btnDeleteAnswer.Text = "Antwoord verwijderen";
            this.btnDeleteAnswer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteAnswer.UseSelectable = true;
            this.btnDeleteAnswer.UseStyleColors = true;
            // 
            // answerField
            // 
            this.answerField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            this.answerField.CustomButton.Image = null;
            this.answerField.CustomButton.Location = new System.Drawing.Point(452, 2);
            this.answerField.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.answerField.CustomButton.Name = "";
            this.answerField.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.answerField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.answerField.CustomButton.TabIndex = 1;
            this.answerField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.answerField.CustomButton.UseSelectable = true;
            this.answerField.CustomButton.Visible = false;
            this.answerField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.answerField.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.answerField.ForeColor = System.Drawing.Color.Black;
            this.answerField.Lines = new string[0];
            this.answerField.Location = new System.Drawing.Point(136, 165);
            this.answerField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.answerField.MaxLength = 32767;
            this.answerField.Multiline = true;
            this.answerField.Name = "answerField";
            this.answerField.PasswordChar = '\0';
            this.answerField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.answerField.SelectedText = "";
            this.answerField.SelectionLength = 0;
            this.answerField.SelectionStart = 0;
            this.answerField.Size = new System.Drawing.Size(488, 38);
            this.answerField.TabIndex = 25;
            this.answerField.UseCustomBackColor = true;
            this.answerField.UseCustomForeColor = true;
            this.answerField.UseSelectable = true;
            this.answerField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.answerField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 822);
            this.Controls.Add(this.mainTablePanel);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddQuestionView";
            this.Padding = new System.Windows.Forms.Padding(22, 38, 22, 25);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Vraag toevoegen";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTablePanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.buttonsTablePanel.ResumeLayout(false);
            this.tableInputFields.ResumeLayout(false);
            this.tableInputFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).EndInit();
            this.tableRadioButtons.ResumeLayout(false);
            this.tableRadioButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTablePanel;
        private System.Windows.Forms.TableLayoutPanel tableInputFields;
        private System.Windows.Forms.ListBox answersListBox;
        private System.Windows.Forms.NumericUpDown timeField;
        private System.Windows.Forms.TableLayoutPanel tableRadioButtons;
        private MetroFramework.Controls.MetroTile titleTile;
        private MetroFramework.Controls.MetroButton btnQuit;
        private MetroFramework.Controls.MetroButton btnSaveQuestion;
        private MetroFramework.Controls.MetroLabel labelQuestionField;
        private MetroFramework.Controls.MetroTextBox questionField;
        private MetroFramework.Controls.MetroRadioButton rbNoTime;
        private MetroFramework.Controls.MetroRadioButton rbSetTime;
        private MetroFramework.Controls.MetroLabel labelTimeField;
        private MetroFramework.Controls.MetroLabel labelAnswerField;
        private MetroFramework.Controls.MetroLabel labelAnswersListBox;
        private MetroFramework.Controls.MetroLabel labelRightAnswer;
        private MetroFramework.Controls.MetroComboBox rightAnswerComboBox;
        private MetroFramework.Controls.MetroButton btnAddAnswer;
        private MetroFramework.Controls.MetroButton btnDeleteAnswer;
        private MetroFramework.Controls.MetroTextBox answerField;
    }
}