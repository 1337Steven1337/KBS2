using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.View.Main;
using Client.Controller.Question;
using System.Net;
using Client.View.Dialogs;

namespace Client.View.Question
{
    public partial class ViewAddQuestion : Form, IAddView<Model.Question>
    {
        private AddQuestionController Controller;

        public ViewAddQuestion()
        {
            InitializeComponent();

            btnSaveQuestion.Click += BtnSaveQuestion_Click;
        }

        private void BtnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                DialogResult dr = new DialogResult();
                ViewConfirmDialog confirm = new ViewConfirmDialog();
                confirm.getLabelConfirm().Text = "Weet u zeker dat u de vraag wilt opslaan?";
                dr = confirm.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    Dictionary<string, object> iDictionary = new Dictionary<string, object>();
                    iDictionary.Add("Text", questionField.Text);
                    iDictionary.Add("Points", pointsField.Value);
                    iDictionary.Add("Time", timeField.Value);

                    this.Controller.SaveQuestion(iDictionary);
                }
            }
            else
            {
                ViewFailedDialog failed = new ViewFailedDialog();
                failed.getLabelFailed().Text = "U heeft nog niet alle velden ingevuld!";
                failed.ShowDialog();
            }
        }

        private Boolean ValidateFields()
        {
            int Time = -1;
            int Points = -1;

            try
            {
                Time = Convert.ToInt32(timeField.Value);
                Points = Convert.ToInt32(pointsField.Value);
            }
            catch(Exception e)
            {

            }

            //return true or false
            return (Time > 0 && Points > 0 && questionField.Text != "");
        }

        public void AddToParent(IView parent)
        {
            ViewMain main = (ViewMain)parent;

            main.AddTablePanel(this.mainTablePanel,2);
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.answersListBox);
        }

        public void SetController(IController controller)
        {
            this.Controller = (AddQuestionController)controller;
        }

        public void ShowSaveResult(Model.Question instance, HttpStatusCode status)
        {
            if(status == HttpStatusCode.Created && instance != null)
            {
                MessageBox.Show("Created");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        
    }
}
