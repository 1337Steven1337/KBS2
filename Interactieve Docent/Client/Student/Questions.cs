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

        private ProgressBar timerProgressBar;

        private List list = null;
        private Question currentQuestion = null;
        private SignalR signalR = null;

        public Questions(int List_Id)
        {
            InitializeComponent();
            this.List_Id = List_Id;

            // tijdelijke button
            button1.Location = new Point(this.Location.X , this.Location.Y + this.Size.Height - ((this.Height / 10 * 3)));
            button1.Size = new Size(this.Width,(this.Height/10*3));

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


                questionLabel.Text = currentQuestion.Text;
                Console.WriteLine(currentQuestion.PredefinedAnswers.Count);

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


    }
}
