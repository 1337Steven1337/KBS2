﻿using System;
using System.Windows.Forms;
using Client.Controller;
using Client.Service.Thread;
using Client.Controller.Main;
using System.Net;
using Client.View.Dialogs;
using Client.View.Question;
using Client.Controller.Question;
using Client.View.QuestionList;
using Client.Controller.QuestionList;

namespace Client.View.Main
{
    public partial class StartView : Form, IStartView
    {
        private ShowStartController Controller;

        public StartView()
        {
            InitializeComponent();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(this.CodeTextBox);
        }

        public void ShowCodeResult(Model.Pincode instance, HttpStatusCode status)
        {
            LoginButton.Enabled = true;
            CodeTextBox.Enabled = true;
            CodeTextBox.Text = "";

            if (status == HttpStatusCode.OK)
            {
                this.Hide();
                this.StartMainScreen();
                this.Controller.Close();
                this.Close();
            }
            else
            {
                FailedDialogView failed = new FailedDialogView();
                failed.getLabelFailed().Text = "De code is incorrect.";
                failed.ShowDialog();
            }
        }

        public void SetController(IController controller)
        {
            this.Controller = (ShowStartController)controller;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(this.CodeTextBox.Text != null && this.CodeTextBox.Text.Length == 6)
            {
                LoginButton.Enabled = false;
                CodeTextBox.Enabled = false;
                Controller.CheckCode(this.CodeTextBox.Text);
            }
        }

        private void StartMainScreen()
        {
            MainView view = new MainView();
            MainController maincontroller = new MainController(view);

            ListQuestionView viewQuestion = new ListQuestionView();
            ListQuestionController questionController = new ListQuestionController(viewQuestion);
            maincontroller.AddController(questionController);

            ListQuestionListView viewQuestionList = new ListQuestionListView();
            ListQuestionListController listQuestionListController = new ListQuestionListController(viewQuestionList);
            maincontroller.AddController(listQuestionListController);

            listQuestionListController.SelectedListChanged += questionController.LoadList;
            listQuestionListController.Load();

            view.ShowDialog();
        }
    }
}
