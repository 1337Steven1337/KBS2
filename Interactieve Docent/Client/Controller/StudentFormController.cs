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


            client = SignalRClient.GetInstance();
            client.connectionStatusChanged += Client_connectionStatusChanged;
            client.Connect();

            QuestionFactory questionFactory = new QuestionFactory();
            questionFactory.QuestionAdded += Factory_questionAdded;

            PredefinedAnswerFactory PAFactory = new PredefinedAnswerFactory();
            PAFactory.PredefinedAnswerAdded += PAFactory_predefinedAnswerAdded;
        }

        public void Factory_questionAdded(Model.Question question)
        {
            this.mainForm.getQuestionList().Questions.Add(question);
        }

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
