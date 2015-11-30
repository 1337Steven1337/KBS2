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
        public int percentageofHeigt { get; set; }

        private int List_Id { get; set; }
        private int currentQuestionIndex = -1;

        private static int ButtonCounter = 0;
        private static int ButtonCounterHorizontal = 0;
        private static int ButtonCounterVertical = 1;

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

            // tijdelijke button
            questionLabel.Size = new Size((int)(this.Width / 10 * 7) - 50, (int)(this.Height / 10 * 5) - 50);

            questionLabel.Location = new Point(50, 50);

            chatBox.Size = new Size(this.Width / 10 * 3, this.Height / 10 * 9);
            chatBoxMessage.Size = new Size(this.Width / 10 * 2, this.Height / 10);
            sendMessageButton.Size = new Size(this.Width / 10, this.Height / 10);

            chatBox.Location = new Point(this.Width / 10 * 7, 0);
            chatBoxMessage.Location = new Point(this.Width / 10 * 7, this.Location.Y + chatBox.Height);
            sendMessageButton.Location = new Point(this.Width / 10 * 9, this.Location.Y + chatBox.Height);


            tempBtn.Size = new Size(this.Width / 10 * 7, (this.Height / 10 * 3));
            questionTimeProgressBar.Size = new Size(this.Width / 10 * 7, this.Size.Height / 10);

            tempBtn.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height - ((this.Height / 10 * 3)));
            questionTimeProgressBar.Location = new Point(0, this.Location.Y + this.Size.Height / 2 + this.Size.Height / 10);

            timeLabel.Location = new Point(questionTimeProgressBar.Location.X + questionTimeProgressBar.Width / 2 - timeLabel.Width / 2, questionTimeProgressBar.Location.Y + questionTimeProgressBar.Height / 2 - timeLabel.Height / 2);

        }


        private void Question_Timer(object sender, EventArgs e)
        {
            if (questionTimeProgressBar.Value > 0)
            {
                questionTimeProgressBar.Value--;
                timeLabel.Text = "" + questionTimeProgressBar.Value;
            }
            else if (questionTimeProgressBar.Value <= 0)
            {
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
            //option.Location = new Point(Width / 2 + option.Width * (ButtonCounterHorizontal), Height - option.Height * (4 - ButtonCounterVertical));
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
                option.Click += AnswerSaveHandler;
                //bereken de grootte
                int precentagePerButton = (int)Math.Ceiling((double)currentQuestion.PredefinedAnswers.Count / 2);
                int heightcounter = 0;
                int locationY = 0;
                int locationX = 0;
                int WorkingArea = 0;
                int ButtonHeightCounter = 0;
                //y locatie berekenen
                percentageofHeigt = 30;
                ButtonHeightCounter = 0;
                ButtonHeightCounter = (int) Math.Floor((double) (answerButtons.Count-1)/2);
                ButtonListCounter = answerButtons.Count;

                if (ButtonListCounter % 2 != 0)
                {
                    locationX = 0;
                }
                else
                {
                    locationX = (Width-chatBox.Width) / 2;
                }

                option.Width = (Width-chatBox.Width)/2;
                WorkingArea = (Height / 100) * 30;
                //ken de hoogte toe
                option.Height = WorkingArea / precentagePerButton;
                locationY = option.Height * (int)ButtonHeightCounter + (Height/100)*70;

                //heightcounter = (int)Math.Floor(ButtonListCounter - 0.5);
                option.Location = new Point(locationX, locationY);
                Controls.Add(option);
            }
        }

        private void AnswerSaveHandler(object sender, System.EventArgs e)
        {
            UserAnswer ua = new UserAnswer();
            ua.PredefinedAnswer_Id = 0;
            ua.Question_ID = currentQuestionIndex;
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
                questionTimeProgressBar.Maximum = currentQuestion.Time;
                questionTimeProgressBar.Value = currentQuestion.Time;
                TimerLimit = currentQuestion.Time;
                questionTimer.Interval = 1000;
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
