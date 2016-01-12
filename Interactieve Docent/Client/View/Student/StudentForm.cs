using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using Client.Service.Thread;
using Client.View.Dialogs;
using Client.Factory;
using Client.Student;
using Client.Controller;

namespace Client.View.Student
{
    public class StudentForm : IView
    {
        Client.Student.QuestionForm mainForm;
        private Button option = null;
        private List<Button> answerButtons = new List<Button>();
        float ButtonListCounter = 2;

        private Timer updateQuestionCountLabelTimer = new Timer();

        private OpenQuestionFactory OpenQuestionFactory = new OpenQuestionFactory();
        private Model.OpenQuestion openQuestion;
        private StudentFormController controller;

        public StudentForm(Client.Student.QuestionForm mainform)
        {
            this.mainForm = mainform;
            updateQuestionCountLabelTimer.Interval = 1;
            updateQuestionCountLabelTimer.Tick += updateLabel;
        }

        public void setController()
        {
            this.controller = mainForm.getController();
        }


        public void startLabelTimer()
        {
            updateQuestionCountLabelTimer.Start();
        }

        public void stopLabelTimer()
        {
            updateQuestionCountLabelTimer.Stop();
        }

        public void updateLabel(object sender, EventArgs e)
        {
            //Update questioncounter label
            mainForm.questionCountLabel.Text = "Vraag: ( " + (controller.getCurrentQuestionIndex() + 1) + "/" + (mainForm.getQuestionList().MCQuestions.Count + mainForm.getQuestionList().OpenQuestions.Count) + ")";

        }

        //This function sets the positions for each control in the QuestionForm
        public void initControlLocations()
        {
            mainForm.Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.8), (int)(Screen.PrimaryScreen.Bounds.Height * 0.8));
            mainForm.statusLabel.Location = new Point(mainForm.Location.X + mainForm.ClientSize.Width / 2 - mainForm.statusLabel.Width / 2, mainForm.Location.Y + mainForm.ClientSize.Height / 2 - mainForm.statusLabel.Height / 2);

            mainForm.openQuestionBox.Size = new Size((int)(mainForm.ClientSize.Width * 0.8), mainForm.ClientSize.Height / 10 * 2);
            mainForm.sendOpenQuestionBtn.Size = new Size((int)(mainForm.ClientSize.Width * 0.2), mainForm.ClientSize.Height / 10 *2);

            mainForm.openQuestionBox.Location = new Point(0, (int)(mainForm.ClientSize.Height * 0.8));
            mainForm.sendOpenQuestionBtn.Location = new Point(mainForm.openQuestionBox.Location.X + mainForm.openQuestionBox.Width, mainForm.openQuestionBox.Location.Y);

            mainForm.getProgressBar().Size = new Size(mainForm.ClientSize.Width, mainForm.ClientSize.Height / 10);
            mainForm.getProgressBar().Location = new Point(0, mainForm.Location.Y + mainForm.ClientSize.Height / 2 + mainForm.ClientSize.Height / 10 - 5);

            mainForm.questionCountLabel.Location = new Point(mainForm.getProgressBar().Location.X + mainForm.getProgressBar().Width - mainForm.questionCountLabel.Width, mainForm.getProgressBar().Location.Y - mainForm.questionCountLabel.Height);


            mainForm.timeLabel.Location = new Point(mainForm.getProgressBar().Location.X + mainForm.getProgressBar().Width / 2 - mainForm.timeLabel.Width / 2, mainForm.getProgressBar().Location.Y + mainForm.getProgressBar().Height / 2 - mainForm.timeLabel.Height / 2);
        }

        //Set openquestion
        public void SetOpenQuestion(Model.OpenQuestion openQuestion)
        {
            this.openQuestion = openQuestion;
            mainForm.statusLabel.Visible = false;
        }

        //Initializing waitScreen
        public void initWaitScreen()
        {
            mainForm.statusLabel.Visible = true;
            mainForm.openQuestionBox.Visible = false;
            mainForm.sendOpenQuestionBtn.Visible = false;
            mainForm.getProgressBar().Visible = false;
            mainForm.questionLabel.Visible = false;
            mainForm.timeLabel.Visible = false;
            mainForm.questionCountLabel.Visible = false;
        }


        //Initializing Multiple Choice screen
        public void initMCQuestionScreen()
        {
            mainForm.statusLabel.Visible = false;
            mainForm.openQuestionBox.Visible = false;
            mainForm.sendOpenQuestionBtn.Visible = false;
            mainForm.getProgressBar().Visible = true;
            mainForm.questionLabel.Visible = true;
            mainForm.timeLabel.Visible = true;
            mainForm.questionCountLabel.Visible = true;
        }

        //Initializing Open Question screen
        //Initializing Multiple Choice screen
        public void initOpenQuestionScreen()
        {
            mainForm.statusLabel.Visible = false;
            mainForm.openQuestionBox.Visible = true;
            mainForm.sendOpenQuestionBtn.Visible = true;
            mainForm.getProgressBar().Visible = false;
            mainForm.questionLabel.Visible = true;
            mainForm.timeLabel.Visible = false;
            mainForm.questionCountLabel.Visible = true;
            mainForm.questionCountLabel.Location = new Point(mainForm.getProgressBar().Location.X + mainForm.getProgressBar().Width - mainForm.questionCountLabel.Width, mainForm.sendOpenQuestionBtn.Location.Y - mainForm.questionCountLabel.Height);
        }









        //Creates a new Button to add to the controls
        private Button createAnswerButton(Model.PredefinedAnswer answer)
        {
            option = new Button();
            answerButtons.Add(option);
            option.Text = answer.Text;
            return option;
        }

        //Removes the previousquestion answerButtons
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

        //Calculates the sizes of the answerButtons
        public void adjustSizeOfButtons(Model.Question Q)
        {
            foreach (Model.PredefinedAnswer PA in Q.PredefinedAnswers)
            {
                if (mainForm.getCurrentMCQuestion().PredefinedAnswers.Count > answerButtons.Count)
                {
                    option = createAnswerButton(PA);
                }

                //Adding eventhandler
                option.Click += controller.AnswerMCSaveHandler;

                //Initializing variables 
                int percentagePerButton = (int)Math.Ceiling((double)mainForm.getCurrentMCQuestion().PredefinedAnswers.Count / 2);
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
                    locationX = mainForm.ClientSize.Width / 2;
                }

                option.Width = mainForm.ClientSize.Width / 2;
                option.Height = mainForm.ClientSize.Height / 10 * 3 / percentagePerButton;
                locationY = (mainForm.ClientSize.Height / 10 * 7) + (option.Height * (int)ButtonHeightCounter);
                option.Location = new Point(locationX, locationY);
                //set de answerID
                option.ImageIndex = PA.Id;
                //Add button to controls
                mainForm.Controls.Add(option);
            }
        }

        public IControlHandler GetHandler()
        {
            return new ControlHandler(mainForm.getProgressBar());
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }
    }
}
