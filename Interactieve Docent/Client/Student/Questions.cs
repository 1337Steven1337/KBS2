using Client.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.API;
using Microsoft.AspNet.SignalR.Client;
using ConnectionState = Microsoft.AspNet.SignalR.Client.ConnectionState;
using System.Diagnostics;

namespace Client.Student
{
    public partial class Questions : Form
    {
        private int List_Id { get; set; }
        private int currentQuestionIndex = -1;

        private bool busy = false;

        private Button option = null;

        private List list = null;
        private List<Button> answerButtons = new List<Button>();

        private Question currentQuestion = null;
        private Timer questionTimer = new Timer();
        private int TimerLimit = -1;
        private SignalR signalR = null;

        float ButtonListCounter = 2;



        public Questions(int List_Id)
        {

            InitializeComponent();
            this.List_Id = List_Id;
            this.Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.8), (int)(Screen.PrimaryScreen.Bounds.Height * 0.8));


            chatBox.Size = new Size(this.ClientSize.Width / 10 * 3, this.ClientSize.Height / 10 * 9);
            chatBoxMessage.Size = new Size(this.ClientSize.Width / 10 * 2, this.ClientSize.Height / 10);
            sendMessageButton.Size = new Size(this.ClientSize.Width / 10, this.ClientSize.Height / 10);

            chatBox.Location = new Point(this.ClientSize.Width / 10 * 7, 0);
            chatBoxMessage.Location = new Point(this.ClientSize.Width / 10 * 7, this.Location.Y + chatBox.Height);
            sendMessageButton.Location = new Point(this.ClientSize.Width / 10 * 9, this.Location.Y + chatBox.Height);


            questionTimeProgressBar.Size = new Size(this.ClientSize.Width / 10 * 7, this.ClientSize.Height / 10);
            questionTimeProgressBar.Location = new Point(0, this.Location.Y + this.ClientSize.Height / 2 + this.ClientSize.Height / 10 - 5);

            timeLabel.Location = new Point(questionTimeProgressBar.Location.X + questionTimeProgressBar.Width / 2 - timeLabel.Width / 2, questionTimeProgressBar.Location.Y + questionTimeProgressBar.Height / 2 - timeLabel.Height / 2);

        }


        private void Question_Timer(object sender, EventArgs e)
        {
            if (questionTimeProgressBar.Value > 0)
            {
                questionTimeProgressBar.Value -= 100;
                timeLabel.Text = "" + Math.Ceiling(questionTimeProgressBar.Value / 1000.00);
            }
            else if (questionTimeProgressBar.Value <= 0)
            {
                questionTimer.Tick -= Question_Timer;
                questionTimer.Stop();
                goToNextQuestion();
            }
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            this.list = List.getById(this.List_Id);

            this.signalR = new SignalR();
            this.signalR.connectionStatusChanged += this.SignalROnConnectionStatusChanged;
            this.signalR.newQuestionAdded += this.SignalROnNewQuestionAdded;
            this.signalR.connect();

            this.goToNextQuestion();

        }

        private Button createAnswerButton(PredefinedAnswer answer)
        {
            option = new Button();
            answerButtons.Add(option);
            option.Text = answer.Text;
            return option;
        }


        private void adjustSizeOfButtons(Question Q)
        {
            foreach (PredefinedAnswer PA in Q.PredefinedAnswers)
            {


                if (currentQuestion.PredefinedAnswers.Count > answerButtons.Count)
                {
                    option = createAnswerButton(PA);
                }

                //Adding eventhandler
                option.Click += AnswerSaveHandler;

                //Initializing variables 
                int percentagePerButton = (int)Math.Ceiling((double)currentQuestion.PredefinedAnswers.Count / 2);
                int locationY = 0;
                int locationX = 0;
                int ButtonHeightCounter = 0;

                //Calculate Y location
                ButtonHeightCounter = (int)Math.Floor((double)(answerButtons.Count - 1) / 2);
                ButtonListCounter = answerButtons.Count;

                if (ButtonListCounter % 2 != 0)
                {
                    locationX = 0;
                }
                else
                {
                    locationX = this.ClientSize.Width / 10 * 7 / 2;
                }

                option.Width = this.ClientSize.Width / 10 * 7 / 2;
                option.Height = this.ClientSize.Height / 10 * 3 / percentagePerButton;
                locationY = (this.ClientSize.Height / 10 * 7) + (option.Height * (int)ButtonHeightCounter);
                option.Location = new Point(locationX, locationY);

                //Add button to controls
                Controls.Add(option);
            }
        }

        private void AnswerSaveHandler(object sender, System.EventArgs e)
        {
            UserAnswer ua = new UserAnswer();
            ua.PredefinedAnswer_Id = 0;
            //ua.Question_ID = currentQuestionIndex;
        }

        private void cleanUpPreviousQuestion()
        {
            foreach (Button button in answerButtons)
            {
                Controls.Remove(button);
            }
        }

        private void goToNextQuestion()
        {
            foreach (Button b in answerButtons)
            {
                Controls.Remove(b);
            }
            answerButtons.Clear();
            currentQuestionIndex++;

            if (list.Questions.Count - 1 >= currentQuestionIndex)
            {
                busy = true;
                cleanUpPreviousQuestion();
                currentQuestion = Question.getById(list.Questions[currentQuestionIndex].Id);
                questionTimeProgressBar.Maximum = currentQuestion.Time * 1000;
                questionTimeProgressBar.Value = currentQuestion.Time * 1000;
                TimerLimit = currentQuestion.Time;
                questionTimer.Interval = 100;
                questionTimer.Tick += Question_Timer;
                questionTimer.Start();
                questionLabel.Text = currentQuestion.Text;
                adjustSizeOfButtons(currentQuestion);
            }
            else if (list.Ended)
            {
                MessageBox.Show("Ended");
            }
            else
            {
                MessageBox.Show("Snackbar");
                busy = false;


            }
        }

        private void SignalROnNewQuestionAdded(Question question)
        {
            list.Questions.Add(question);

            if (!busy)
            {
                currentQuestionIndex--;
                goToNextQuestion();
            }
        }

        private void SignalROnConnectionStatusChanged(StateChange message)
        {
            if (message.NewState == ConnectionState.Connected)
            {
                signalR.subscribe(list.Id);
            }
        }

        private ProgressBar createProgressBar()
        {
            ProgressBar SecondsLeft = new ProgressBar();
            SecondsLeft.Location = new System.Drawing.Point(0, 243);
            SecondsLeft.Name = "Time";
            SecondsLeft.Size = new System.Drawing.Size(Width, 23);
            SecondsLeft.TabIndex = 0;
            SecondsLeft.Maximum = 100;

            SecondsLeft.Step = 1;

            return SecondsLeft;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
