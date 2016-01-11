using Client.Controller.QuestionList;
using Client.View.Dialogs;
using Client.View.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.QuestionList
{
    public partial class RenameQuestionList : Form
    {
        private int QuestionListId;

        private Button btnOk;
        private Button btnCancel;

        private TextBox textBox;

        private Label textLabel;

        private ListQuestionListController Controller;

        public Boolean QuestionListNameChanged;
        
        public RenameQuestionList(int Id, ListQuestionListController Controller)
        {
            InitializeComponent();

            this.Controller = Controller;

            this.QuestionListId = Id;
            this.QuestionListNameChanged = false;

            textLabel = new Label() { Left = 50, Top = 20, Text = "Vraag:" }; ;
            textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            btnCancel = new Button() { Left = 300, Top = 75, Width = 70, Height = 30, Text = "Annuleren" };
            btnOk = new Button() { Left = 380, Top = 75, Width = 70, Height = 30, Text = "Opslaan" };

            this.Width = 500;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Wijzig vraag";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            this.Controls.Add(textLabel);
            this.Controls.Add(textBox);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);

            this.btnOk.Click += BtnOk_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = "Weet u zeker dat u de naam van de vragenlijst wilt wijzigen?";
                dr = confirm.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    Model.QuestionList questionList = new Model.QuestionList();
                    questionList.Id = QuestionListId;
                    questionList.Name = textBox.Text;
                    Controller.UpdateQuestionList(questionList);

                    this.QuestionListNameChanged = true;
                    confirm.Close();
                }
            }
            else
            {
                MessageBox.Show("U heeft niks ingevuld, vul alstublieft de nieuwe naam in");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox.Text))
            {
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = "U heeft een andere naam ingevuld, weet u zeker dat u wilt annuleren?";
                dr = confirm.ShowDialog();

                if(dr == DialogResult.Yes)
                {
                    confirm.Close();
                    this.Close();
                }
                else
                {
                    confirm.Close();
                }

            }
            else
            {
                this.Close();
            }
        }
    }
}
