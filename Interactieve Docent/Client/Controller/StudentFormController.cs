using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Service.SignalR;
using Client.Factory;
using Microsoft.AspNet.SignalR.Client;

namespace Client.Controller
{
    class StudentFormController
    {
        private Student.QuestionForm mainForm;
        private int currentQuestionIndex = -1;
        SignalRClient client;

        public StudentFormController(Student.QuestionForm mainform)
        {
            this.mainForm = mainform;



            //Connect (this) client to the session
            client = SignalRClient.GetInstance();
            client.connectionStatusChanged += Client_connectionStatusChanged;
            client.Connect();

            //Adds an event to the QuestionAdded function which is called when a new question is added by the teacher.
            QuestionFactory questionFactory = new QuestionFactory();
            questionFactory.QuestionAdded += Factory_questionAdded;


            //Adds an event to the QuestionListContinue function which is called when the teacher presses "Next" button for the next question.
            QuestionListFactory listFactory = new QuestionListFactory();
            listFactory.QuestionListContinue += LIFactory_continue;


            //Adds an event to the PredefinedAnswerAdded function which is called for each PredefinedAnswer in the next question.
            PredefinedAnswerFactory PAFactory = new PredefinedAnswerFactory();
            PAFactory.PredefinedAnswerAdded += PAFactory_predefinedAnswerAdded;


        }


        //This function is called when the teacher presses "Next Question"
        //This function calls the goToNextQuestion function in the QuestionForm.
        private void LIFactory_continue()
        {

                mainForm.Invoke((Action) delegate() { this.mainForm.goToNextQuestion(); });
        }


        //This function adds the question (which is retrieved from the server) to the locally stored questionList
        public void Factory_questionAdded(Model.Question question)
        {
            this.mainForm.getQuestionList().Questions.Add(question);
        }

        //This function adds the PredefinedAnswers to the question once a question is added
        private void PAFactory_predefinedAnswerAdded(Model.PredefinedAnswer answer)
        {
            Model.Question question = this.mainForm.getQuestionList().Questions.Find(x => x.Id == answer.Question_Id);

            if (question.PredefinedAnswers == null)
            {
                question.PredefinedAnswers = new List<Model.PredefinedAnswer>();
            }

            question.PredefinedAnswers.Add(answer);
            
            if (!mainForm.isBusy() && question.PredefinedAnswers.Count == question.PredefinedAnswerCount)
            {
                mainForm.Invoke((Action)delegate () { mainForm.goToNextQuestion(); });
            }
        }

        //Subscribes the client to a group/session
        private void Client_connectionStatusChanged(StateChange message)
        {
            client.Subscribe(mainForm.List_Id);
        }



        public int getCurrentQuestionIndex()
        {
            return this.currentQuestionIndex;
        }

        public void setCurrentQuestionIndex(int index)
        {
            this.currentQuestionIndex = index;   
        }

    }
}
