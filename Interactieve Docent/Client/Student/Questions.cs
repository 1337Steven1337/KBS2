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
        static int ButtonCounter = 0;
        static int ButtonCounterHorizontal = 0;
        static int ButtonCounterVertical = 1;
        private List<Button> answerButtons = new List<Button>();


        private List list = null;
        private Question currentQuestion = null;
        private Timer questionTimer = new Timer();
        private Timer progressBarTimer = new Timer();
        private SignalR signalR = null;

        public Questions(int List_Id)
        {
            InitializeComponent();
            this.List_Id = List_Id;
            this.Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.8), (int)(Screen.PrimaryScreen.Bounds.Height * 0.8));

            // tijdelijke button
            questionLabel.Size = new Size((int)(this.Width/10*7) - 50,(int)(this.Height/10*5) - 50);

            questionLabel.Location = new Point(50,50);


            chatBox.Size = new Size(this.Width/10*3,this.Height/10*9);
            chatBoxMessage.Size = new Size(this.Width/10*2, this.Height/10);
            sendMessageButton.Size = new Size(this.Width/10, this.Height/10);

            chatBox.Location = new Point(this.Width/10*7,0);
            chatBoxMessage.Location = new Point(this.Width/10*7,this.Location.Y+chatBox.Height);
            sendMessageButton.Location = new Point(this.Width/10*9, this.Location.Y+chatBox.Height);


            tempBtn.Size = new Size(this.Width / 10 * 7, (this.Height / 10 * 3));
            questionTimeProgressBar.Size = new Size(this.Width/10*7,this.Size.Height/10);

            tempBtn.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height - ((this.Height / 10 * 3)));
            questionTimeProgressBar.Location = new Point(0,this.Location.Y + this.Size.Height/2 + this.Size.Height/10);

        }


        private void Question_UpdateProgressBar(object sender, EventArgs e)
        {
            questionTimeProgressBar.Value -= questionTimeProgressBar.Maximum / currentQuestion.Time / 100;
        }

        private void Question_TimerStop(object sender, EventArgs e)
        {
            questionTimer.Stop();
            progressBarTimer.Stop();
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
            Button option = new Button();
            option.Text = answer.Text;
            option.Location = new Point(Width / 2 + option.Width * (ButtonCounterHorizontal), Height - option.Height * (4 - ButtonCounterVertical));
            ButtonCounter++;
            if (ButtonCounter % 2 == 0)
            {
                ButtonCounterVertical++;
                ButtonCounter = 0;
            }
            if (ButtonCounterHorizontal <= 2)
            {
                ButtonCounterHorizontal += 1;
            }
            else
            {
                ButtonCounterHorizontal = 0;
            }


            return option;
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
            currentQuestionIndex++;

            if (list.Questions.Count - 1 >= currentQuestionIndex)
            {
                busy = true;
                cleanUpPreviousQuestion();
                currentQuestion = Question.getById(list.Questions[currentQuestionIndex].Id);

                questionTimeProgressBar.Maximum = currentQuestion.Time * 1000;
                questionTimeProgressBar.Value = currentQuestion.Time * 1000;

                questionTimer.Interval = currentQuestion.Time * 1000;
                questionTimer.Tick += Question_TimerStop;
                questionTimer.Start();

                progressBarTimer.Interval = 10;
                progressBarTimer.Tick += Question_UpdateProgressBar;
                progressBarTimer.Start();
                

                questionLabel.Text = currentQuestion.Text;

                foreach (PredefinedAnswer pa in currentQuestion.PredefinedAnswers)
                {
                    createAnswerButton(pa);
                }
            }
            else if (list.Ended)
            {
                MessageBox.Show("Ended");
            }
            else
            {
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
