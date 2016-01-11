using Client.Factory;
using Client.Service.SignalR;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionState = Microsoft.AspNet.SignalR.Client.ConnectionState;
using Client.Model;
using System.Net;
using Client.View.Student;
using Client.Controller;

namespace Client.Student
{
    public partial class QuestionForm : Form
    {
        public int List_Id { get; set; }
        private bool busy = false;
        private Timer questionTimer = new Timer();
        private Model.Question currentMCQuestion = null;
        private Model.OpenQuestion currentOpenQuestion = null;
        private Model.QuestionList questionList = new Model.QuestionList();
        private StudentFormController controller;
        private StudentForm view;

        public QuestionForm()
        {
            
        }

        //Initializing controller & view
        public QuestionForm(int List_Id)
        {
            InitializeComponent();
            this.List_Id = List_Id;
            this.view = new StudentForm(this);
            this.controller = new StudentFormController(this);

            this.view.setController();
            view.initControlLocations();
            view.initWaitScreen();
            questionTimer.Interval = 100;
            questionTimer.Tick += Question_Timer;
        }

        public StudentForm getView()
        {
            return this.view;
        }

        public StudentFormController getController()
        {
            return this.controller;
        }


        public ProgressBar getProgressBar()
        {
            return this.questionTimeProgressBar;
        }

        public Model.QuestionList getQuestionList()
        {
            return this.questionList;
        }


        public bool isBusy()
        {
            return busy;
        }

        public Timer getTimer()
        {
            return questionTimer;
        }

        public Model.Question getCurrentMCQuestion()
        {
            return this.currentMCQuestion;
        }

        public Model.OpenQuestion getCurrentOpenQuestion()
        {
            return this.currentOpenQuestion;
        }

        //If a time is set this is the event that is executed when the timer is over
        //It resets the timer variables and then goes to the nextquestion event
        private void Question_Timer(object sender, EventArgs e)
        {
            if (questionTimeProgressBar.Value > 0)
            {
                questionTimeProgressBar.Value -= 100;
                timeLabel.Text = "" + Math.Ceiling(questionTimeProgressBar.Value / 1000.00);
            }
            else if (questionTimeProgressBar.Value <= 0)
            {
                busy = false;
                questionTimer.Stop();

                if (this.questionList.MCQuestions.Count - 1 > controller.getCurrentQuestionIndex())
                {
                    goToNextQuestion();
                }
                else
                {
                    view.cleanUpPreviousQuestion();
                    view.initWaitScreen();
                }
            }
        }


        //When called it will stop the timer, and reset all the values back to their original value.
        //Then calls initWaitScreen to reinitialize the waiting screen.
        public void stopQuestionList()
        {
            if (isBusy())
            {
                questionTimer.Stop();
            }

            SignalRClient.GetInstance().UnsubscribeList(this.questionList);
            this.questionList = new QuestionList();
            goToNextQuestion();

        }

        //Literally goes to the next question if there is one, otherwise it'll go back to the waitingscreen.
        public void goToNextQuestion()
        {
            view.startLabelTimer();

            view.cleanUpPreviousQuestion();
            view.getAnswerButtons().Clear();
            questionTimer.Stop();

            if (controller.getCurrentQuestionIndex() == -5)
            {
                controller.setCurrentQuestionIndex(-1);
            }
            else
            {
                controller.setCurrentQuestionIndex(controller.getCurrentQuestionIndex() + 1);
            }
            
            


            if (this.questionList.MCQuestions.Count + this.questionList.OpenQuestions.Count  - 1 >= controller.getCurrentQuestionIndex())
            {
                if (controller.getCurrentQuestionIndex() < this.questionList.MCQuestions.Count)
                {
                    view.initMCQuestionScreen();
                    busy = true;
                    questionTimeProgressBar.Value = questionTimeProgressBar.Maximum;

                    currentMCQuestion = this.questionList.MCQuestions[controller.getCurrentQuestionIndex()];
                    if (currentMCQuestion.Time > 1)
                    {
                        questionTimeProgressBar.Maximum = currentMCQuestion.Time * 1000;
                        questionTimeProgressBar.Value = currentMCQuestion.Time * 1000;
                        questionTimer.Start();
                        this.questionCountLabel.Location = new Point(this.getProgressBar().Location.X + this.getProgressBar().Width - this.questionCountLabel.Width, this.getProgressBar().Location.Y - this.questionCountLabel.Height);
                    }
                    else
                    {
                        questionTimeProgressBar.Visible = false;
                        timeLabel.Visible = false;
                        this.questionCountLabel.Location = new Point(this.getProgressBar().Location.X + this.getProgressBar().Width - this.questionCountLabel.Width, this.getProgressBar().Location.Y + this.getProgressBar().Height - this.questionCountLabel.Height);
                    }
                    this.view.adjustSizeOfButtons(currentMCQuestion);
                    questionLabel.Text = currentMCQuestion.Text;
                }
                else
                {
                    view.initOpenQuestionScreen();
                    currentOpenQuestion = this.questionList.OpenQuestions[controller.getCurrentQuestionIndex() - this.questionList.MCQuestions.Count];
                    busy = true;
                    questionLabel.Text = currentOpenQuestion.Text;
                }

                
            }
            else if (this.questionList.Ended)
            {
                MessageBox.Show("Realtime vragenlijst af.");
                
            }
            else
            {
                view.initWaitScreen();
                questionTimer.Stop();
                view.stopLabelTimer();
                busy = false;
            }
        }

    }
}


