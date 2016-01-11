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
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;

using MetroFramework;
using System.Windows.Forms;

namespace Client.View.QuestionList
{
    public partial class RenameQuestionList : MetroForm
    {
        private int QuestionListId;

        private ListQuestionListController Controller;

        public Boolean QuestionListNameChanged;
        
        public RenameQuestionList(int Id, String name, ListQuestionListController Controller)
        {
            InitializeComponent();

            this.Controller = Controller;

            this.QuestionListId = Id;
            this.QuestionListNameChanged = false;
            this.textBox.Text = name;
        }

        private void BtnSave_Click(object sender, EventArgs e)
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
