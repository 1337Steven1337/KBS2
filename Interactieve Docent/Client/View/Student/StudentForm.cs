using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace Client.View.Student
{
    class StudentForm
    {
        //variables
        Client.Student.QuestionForm mainForm;
        private Button option = null;
        private List<Button> answerButtons = new List<Button>();
        float ButtonListCounter = 2;

        public StudentForm(Client.Student.QuestionForm mainform)
        {
            this.mainForm = mainform;
        }

        public void initControlLocations()
        {
            mainForm.Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.8), (int)(Screen.PrimaryScreen.Bounds.Height * 0.8));
            mainForm.statusLabel.Location = new Point(mainForm.Location.X + mainForm.ClientSize.Width / 2 - mainForm.statusLabel.Width / 2, mainForm.Location.Y + mainForm.ClientSize.Height / 2 - mainForm.statusLabel.Height / 2);

            mainForm.chatBox.Size = new Size(mainForm.ClientSize.Width / 10 * 3, mainForm.ClientSize.Height / 10 * 9);
            mainForm.chatBoxMessage.Size = new Size(mainForm.ClientSize.Width / 10 * 2, mainForm.ClientSize.Height / 10);
            mainForm.sendMessageButton.Size = new Size(mainForm.ClientSize.Width / 10, mainForm.ClientSize.Height / 10);

            mainForm.chatBox.Location = new Point(mainForm.ClientSize.Width / 10 * 7, 0);
            mainForm.chatBoxMessage.Location = new Point(mainForm.ClientSize.Width / 10 * 7, mainForm.Location.Y + mainForm.chatBox.Height);
            mainForm.sendMessageButton.Location = new Point(mainForm.ClientSize.Width / 10 * 9, mainForm.Location.Y + mainForm.chatBox.Height);


            mainForm.getProgressBar().Size = new Size(mainForm.ClientSize.Width / 10 * 7, mainForm.ClientSize.Height / 10);
            mainForm.getProgressBar().Location = new Point(0, mainForm.Location.Y + mainForm.ClientSize.Height / 2 + mainForm.ClientSize.Height / 10 - 5);

            mainForm.timeLabel.Location = new Point(mainForm.getProgressBar().Location.X + mainForm.getProgressBar().Width / 2 - mainForm.timeLabel.Width / 2, mainForm.getProgressBar().Location.Y + mainForm.getProgressBar().Height / 2 - mainForm.timeLabel.Height / 2);

        }

        //hide some items when waiting for the next question and show the waiting label
        public void initWaitScreen()
        {
            mainForm.statusLabel.Visible = true;
            mainForm.chatBox.Visible = false;
            mainForm.chatBoxMessage.Visible = false;
            mainForm.sendMessageButton.Visible = false;
            mainForm.getProgressBar().Visible = false;
            mainForm.questionLabel.Visible = false;
            mainForm.timeLabel.Visible = false;
        }

        //hide the waiting label and show the question content
        public void initQuestionScreen()
        {
            mainForm.statusLabel.Visible = false;
            mainForm.chatBox.Visible = true;
            mainForm.chatBoxMessage.Visible = true;
            mainForm.sendMessageButton.Visible = true;
            mainForm.getProgressBar().Visible = true;
            mainForm.questionLabel.Visible = true;
            mainForm.timeLabel.Visible = true;
        }

        //DEZE MOET ER NOG UIT???????????????!!!!!!!!!!!!!!!!!!!!!!!!!!!!&&&^^#^@gsdfdbdf%!%@$%@#$%#$&$%*%^*(*(&$%^@%$!@#$@#$^#$&^%&*!%
        private void whatever(Client.Model.UserAnswer ua, HttpStatusCode code)
        {
            if (code == HttpStatusCode.Forbidden)
            {

            }
        }

        //Save the selected answer and initiate waiting screen
        public void AnswerSaveHandler(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            Client.Model.UserAnswer ua = new Client.Model.UserAnswer();
            ua.PredefinedAnswer_Id = btn.ImageIndex;
            ua.Question_Id = mainForm.getCurrentQuestion().Id;

            Factory.UserAnswerFactory uaf = new Factory.UserAnswerFactory();
            uaf.Save(ua, null, this.whatever);
            if (mainForm.getQuestionList().Questions.Count - 1 > 5)
            {
                mainForm.goToNextQuestion();
            }
            else
            {
                this.cleanUpPreviousQuestion();
                this.initWaitScreen();
            }
        }

        //Create the button for the answers
        private Button createAnswerButton(Model.PredefinedAnswer answer)
        {
            option = new Button();
            answerButtons.Add(option);
            option.Text = answer.Text;
            return option;
        }

        public void cleanUpPreviousQuestion()
        {
            foreach (Button button in answerButtons)
            {
                mainForm.Controls.Remove(button);
            }
        }

        public List<Button> getAnswerButtons()
        {
            return this.answerButtons;
        }

        //make sure that every button has a good position on the screen
        public void adjustSizeOfButtons(Model.Question Q)
        {
            foreach (Model.PredefinedAnswer PA in Q.PredefinedAnswers)
            {
                if (mainForm.getCurrentQuestion().PredefinedAnswers.Count > answerButtons.Count)
                {
                    option = createAnswerButton(PA);
                }

                //Adding eventhandler
                option.Click += AnswerSaveHandler;

                //Initializing variables 
                int percentagePerButton = (int)Math.Ceiling((double)mainForm.getCurrentQuestion().PredefinedAnswers.Count / 2);
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
                    locationX = mainForm.ClientSize.Width / 10 * 7 / 2;
                }

                option.Width = mainForm.ClientSize.Width / 10 * 7 / 2;
                option.Height = mainForm.ClientSize.Height / 10 * 3 / percentagePerButton;
                locationY = (mainForm.ClientSize.Height / 10 * 7) + (option.Height * (int)ButtonHeightCounter);
                option.Location = new Point(locationX, locationY);
                //set de answerID
                option.ImageIndex = PA.Id;
                //Add button to controls
                mainForm.Controls.Add(option);
            }
        }
    }
}
