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

namespace Client.Student
{
    public partial class QuestionForm : Form
    {
        public int List_Id { get; set; }
        private bool busy = false;
        private Timer questionTimer = new Timer();
        private Model.Question currentQuestion = null;
        private Model.QuestionList questionList = new Model.QuestionList();
        private Controller.StudentFormController controller;
        private View.Student.StudentForm view;

        public QuestionForm()
        {

            view = new View.Student.StudentForm(this);

        }

        public QuestionForm(int List_Id)
        {
            InitializeComponent();
            this.List_Id = List_Id;
            controller = new Controller.StudentFormController(this);
            view = new View.Student.StudentForm(this);
            view.initControlLocations();
            view.initWaitScreen();

            //nextForm next = new nextForm();
            //next.Show();

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


        public Model.Question getCurrentQuestion()
        {
            return this.currentQuestion;
        }

        //
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
                questionTimer.Tick -= Question_Timer;
                questionTimer.Stop();

                if (this.questionList.Questions.Count - 1 > controller.getCurrentQuestionIndex())
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

        public void goToNextQuestion()
        {
            view.cleanUpPreviousQuestion();
            view.initQuestionScreen();
            questionTimer.Stop();
            questionTimeProgressBar.Value = questionTimeProgressBar.Maximum;
            view.getAnswerButtons().Clear();

            controller.setCurrentQuestionIndex(controller.getCurrentQuestionIndex() + 1);

            if (this.questionList.Questions.Count - 1 >= controller.getCurrentQuestionIndex())
            {
                busy = true;

                currentQuestion = this.questionList.Questions[controller.getCurrentQuestionIndex()];
                if (currentQuestion.Time != 0)
                {
                    questionTimeProgressBar.Visible = false;
                    timeLabel.Visible = false;
                    questionTimeProgressBar.Maximum = currentQuestion.Time * 1000;
                    questionTimeProgressBar.Value = currentQuestion.Time * 1000;
                    questionTimer.Interval = 100;
                    questionTimer.Tick += Question_Timer;
                    questionTimer.Start();
                }
                else
                {
                    questionTimeProgressBar.Visible = false;
                    timeLabel.Visible = false;
                }
                questionLabel.Text = currentQuestion.Text;
                this.view.adjustSizeOfButtons(currentQuestion);
            }
            else if (this.questionList.Ended)
            {
                //if the list ended, there are no further question than notify the student
                MessageBox.Show("Realtime vragenlijst af.");
            }
            else
            {
                view.initWaitScreen();
                questionTimer.Stop();
                busy = false;
            }
        }
    }
}


