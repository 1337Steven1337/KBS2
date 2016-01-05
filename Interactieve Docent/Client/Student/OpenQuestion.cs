using Client.Controller;
using Client.Factory;
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

namespace Client.Student
{
    public partial class OpenQuestion : Form
    {

        private Model.OpenQuestion currentOpenQuestion = new Model.OpenQuestion();
        private Label QuestionLabel;
        public int Question_Id { get; set; }
        private OpenQuestionController controller;
        private OpenQuestionFactory factory = new OpenQuestionFactory();

        public OpenQuestion(int Question_Id)
        {
            controller = new OpenQuestionController(this);
            this.Question_Id = Question_Id;
            InitializeComponent();
            QuestionLabel = OpenQuestionController.Addlabel("Welk gevoel krijg jij bij het woord banaan?");
            TextBox textbox = OpenQuestionController.AddTextBox(Width,Height);
            Button button = OpenQuestionController.AddButton(Width, Height);
            QuestionLabel.Location = new Point((Width / 2) - (QuestionLabel.Width / 2));
            Controls.Add(button);
            Controls.Add(QuestionLabel);
            Controls.Add(textbox);
            factory.OpenQuestionAdded += QuestionText;
            GoToNextQuestion();
            InitializeComponent();
        }


        public void QuestionText(Model.OpenQuestion OQ)
        {
            QuestionLabel.Text = OQ.Text;
        }

        public string getCurrentQuestion()
        {
            return this.currentOpenQuestion.Text;
        }

        public void GoToNextQuestion()
        {

            controller.setCurrentQuestionIndex(controller.getCurrentQuestionIndex() + 1);
            currentOpenQuestion.Id = Question_Id;
            Debug.WriteLine("Id = " + currentOpenQuestion.Id);
            QuestionLabel.Text = getCurrentQuestion();
        }
    }
}
