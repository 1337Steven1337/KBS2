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
using Client.Service.SignalR;
using Client.Factory;

namespace Client.Student
{
    public partial class QuestionForm : Form
    {
        private int List_Id { get; set; }
        private int currentQuestionIndex = -1;

        private bool busy = false;

        private Button option = null;

        private Model.QuestionList list = new Model.QuestionList();
        private List<Button> answerButtons = new List<Button>();

        private Model.Question currentQuestion = null;
        private Timer questionTimer = new Timer();

        float ButtonListCounter = 2;

        SignalRClient client;

        public QuestionForm(int List_Id)
        {
            InitializeComponent();
            this.List_Id = List_Id;
            initControlLocations();
            initWaitScreen();

            Main main = new Main();
            main.Show();

            client = SignalRClient.getInstance();
            client.connectionStatusChanged += Client_connectionStatusChanged;
            client.connect();

            QuestionFactory questionFactory = new QuestionFactory();
            questionFactory.questionAdded += Factory_questionAdded;

            PredefinedAnswerFactory PAFactory = new PredefinedAnswerFactory();
            PAFactory.predefinedAnswerAdded += PAFactory_predefinedAnswerAdded;
        }

        public void initControlLocations()
        {
            this.Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.8), (int)(Screen.PrimaryScreen.Bounds.Height * 0.8));
            this.statusLabel.Location = new Point(this.Location.X + this.ClientSize.Width / 2 - this.statusLabel.Width / 2, this.Location.Y + this.ClientSize.Height / 2 - this.statusLabel.Height / 2);

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

        public void initWaitScreen()
        {
            this.statusLabel.Visible = true;
            this.chatBox.Visible = false;
            this.chatBoxMessage.Visible = false;
            this.sendMessageButton.Visible = false;
            this.questionTimeProgressBar.Visible = false;
            this.questionLabel.Visible = false;
            this.timeLabel.Visible = false;
        }

        public void initQuestionScreen()
        {
            this.statusLabel.Visible = false;
            this.chatBox.Visible = true;
            this.chatBoxMessage.Visible = true;
            this.sendMessageButton.Visible = true;
            this.questionTimeProgressBar.Visible = true;
            this.questionLabel.Visible = true;
            this.timeLabel.Visible = true;
       }

        public void Factory_questionAdded(Model.Question question)
        {
            this.list.Questions.Add(question);
        }

        private void PAFactory_predefinedAnswerAdded(Model.PredefinedAnswer answer)
        {
            Console.WriteLine("PAFactory_predefinedAnswerAdded");
            Model.Question question = this.list.Questions.Find(x => x.Id == answer.Question_Id);

            if(question.PredefinedAnswers == null)
            {
                question.PredefinedAnswers = new List<Model.PredefinedAnswer>();
            }

            question.PredefinedAnswers.Add(answer);

            //this.Invoke((Action)delegate () { this.adjustSizeOfButtons(question); });
            if (!busy && question.PredefinedAnswers.Count == question.PredefinedAnswerCount)
            {
                this.Invoke((Action)delegate () { this.goToNextQuestion(); });
            }
        }

        private void Client_connectionStatusChanged(StateChange message)
        {
            client.subscribe(this.List_Id);
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
                busy = false;
                questionTimer.Tick -= Question_Timer;
                questionTimer.Stop();
                if (this.list.Questions.Count - 1 > currentQuestionIndex)
                {
                    goToNextQuestion();
                }
                else
                {
                    cleanUpPreviousQuestion();
                    initWaitScreen();
                }
            }
        }

        private Button createAnswerButton(Model.PredefinedAnswer answer)
        {
            option = new Button();
            answerButtons.Add(option);
            option.Text = answer.Text;
            return option;
        }


        private void adjustSizeOfButtons(Model.Question Q)
        {
            Console.WriteLine("adjustSizeOfButtons");
            foreach (Model.PredefinedAnswer PA in Q.PredefinedAnswers)
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
                //set de answerID
                option.ImageIndex = PA.Id;
                //Add button to controls
                Controls.Add(option);
            }
        }

        private void AnswerSaveHandler(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            UserAnswer ua = new UserAnswer();
            ua.PredefinedAnswer_Id = btn.ImageIndex;
            ua.Question_ID = currentQuestion.Id;
            ua.saveAnswer();
            //UserAnswerFactory uaf = new UserAnswerFactory();
            //uaf.save(ua,null, null);
            if (this.list.Questions.Count - 1 > currentQuestionIndex)
            {
                goToNextQuestion();
            }
            else
            {
                cleanUpPreviousQuestion();
                initWaitScreen();
            }
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
            cleanUpPreviousQuestion();
            initQuestionScreen();
            questionTimer.Stop();
            questionTimeProgressBar.Value = questionTimeProgressBar.Maximum;
            answerButtons.Clear();

            currentQuestionIndex++;

            if (list.Questions.Count - 1 >= currentQuestionIndex)
            {
                busy = true;
                //currentQuestion = Question.getById(list.Questions[currentQuestionIndex].Id);
                currentQuestion = this.list.Questions[currentQuestionIndex];

                questionTimeProgressBar.Maximum = currentQuestion.Time * 1000;
                questionTimeProgressBar.Value = currentQuestion.Time * 1000;
                questionTimer.Interval = 100;
                questionTimer.Tick += Question_Timer;
                questionTimer.Start();
                questionLabel.Text = currentQuestion.Text;
                this.adjustSizeOfButtons(currentQuestion);
            }
            else if (list.Ended)
            {
                MessageBox.Show("Realtime vragenlijst af.");
            }
            else
            {
                initWaitScreen();
                questionTimer.Stop();
                busy = false;
            }
        }
    }
}


