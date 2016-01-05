using Client.Controller.QuestionList;
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
            
            //place the items
            textLabel = new Label() { Left = 50, Top = 20, Text = "Vraag:" }; ;
            textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            btnCancel = new Button() { Left = 300, Top = 75, Width = 70, Height = 30, Text = "Annuleren" };
            btnOk = new Button() { Left = 380, Top = 75, Width = 70, Height = 30, Text = "Opslaan" };

            this.Width = 500;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Wijzig vraag";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //add the items to the dialog 
            this.Controls.Add(textLabel);
            this.Controls.Add(textBox);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);

            //add events
            this.btnOk.Click += BtnOk_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        //if the users clicked Ok, do the following
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //check if the textbox is not empty
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                //if it is not empty ask for a confirm
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = "Weet u zeker dat u de naam van de vragenlijst wilt wijzigen?";
                dr = confirm.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    //if the users confirms update the question
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
                //if the textbox is empty warn the user
                MessageBox.Show("U heeft niks ingevuld, vul alstublieft de nieuwe naam in");
            }
        }

        //if the users clicked Cancel, do the following
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //if the textbox is not empty
            if(!String.IsNullOrEmpty(textBox.Text))
            {
                //warn the user that the information will be lost if he continues
                DialogResult dr = new DialogResult();
                ConfirmDialogView confirm = new ConfirmDialogView();
                confirm.getLabelConfirm().Text = "U heeft een andere naam ingevuld, weet u zeker dat u wilt annuleren?";
                dr = confirm.ShowDialog();

                if(dr == DialogResult.Yes)
                {
                    //if he continues close the dialogs
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
                //if the textbox is empty, close the dialog
                this.Close();
            }
        }
    }
}
