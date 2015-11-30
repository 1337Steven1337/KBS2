﻿using Client.API;
using Client.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class diagram : Form
    {
        #region Variables & Instances
        public int Question_Id;

        public List<string> questions;
        public List<int> votes;

        public Question question;
        
        private Dictionary<string, int> questionVotes = new Dictionary<string, int>();

        private SignalR UserAnswerFactory;
        #endregion

        #region Constructor & Onload
        public diagram(int Question_Id)
        {
            this.Question_Id = Question_Id;
            InitializeComponent();
            Invalidate();
        }

        private void diagram_Load(object sender, EventArgs e)
        {
            //select a question
            question = Question.getById(Question_Id);
            Controller();
            this.UserAnswerFactory = new SignalR();
            this.UserAnswerFactory.connectionStatusChanged += SignalR_connectionStatusChanged;
            this.UserAnswerFactory.subscriptionStatusChanged += SignalR_subscriptionStatusChanged;
            this.UserAnswerFactory.newUserAnswerAdded += SignalR_newUserAnswerAdded;
            this.UserAnswerFactory.connect();
        }
        #endregion

        #region Events
        private void SignalR_newUserAnswerAdded(UserAnswer userAnswer)
        {
            this.question.UserAnswers.Add(userAnswer);
            Controller();
        }

        private void SignalR_subscriptionStatusChanged(API.EventArgs.SubscriptionStatus message)
        {
            
        }

        private void SignalR_connectionStatusChanged(Microsoft.AspNet.SignalR.Client.StateChange message)
        {
            if(message.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
            {
                UserAnswerFactory.subscribe(question.List_Id);
            }
            else if(message.NewState == Microsoft.AspNet.SignalR.Client.ConnectionState.Connecting){

            }
            else
            {
                MessageBox.Show("Helaas! Faggot..");
            }
        }
        #endregion

        #region Methodes
        public void Controller()
        {
            GetData();
            this.Invoke((Action)delegate () { MakeDiagram(votes, questions, question.Text); });
        }

        public void MakeDiagram(List<int> values, List<string> answerNames, string question)
        {
            chart1.Series.Clear();

            //add columns to the diagram
            for (int i = 0; i < answerNames.Count; i++)
            {
                chart1.Series.Add(CreateColumn(answerNames[i], values[i]));
            }
            //add question above the diagram
            textBox1.Text = question;
        }

        //create column
        public Series CreateColumn(string answerName, int value)
        {
            DataPoint Column = new DataPoint();
            Column.XValue = 5;             //x value
            double[] values = { value };  //y value
            Column.YValues = values;

            Series series = new Series();
            series.ChartArea = "ChartArea1";
            series.Legend = "Legend1";
            series.Name = answerName; //name column
            series.Points.Add(Column);
            return series;
        }

        public void GetData()
        {
            //if the predefinedanswer is empty zet votes to zero
            foreach (PredefinedAnswer preAnswer in question.PredefinedAnswers)
            {
                questionVotes[preAnswer.Text] = 0;
            }

            //for every given answer were the userAnswer_Id is equal to a PredefinedAnswer_Id add one to votes
            foreach (UserAnswer answer in question.UserAnswers)
            {
                string text = question.PredefinedAnswers.Find(x => x.Id == answer.PredefinedAnswer_Id).Text;
                questionVotes[text] += 1;
            }

            votes = questionVotes.Values.ToList<int>();
            questions = questionVotes.Keys.ToList<string>();
            
        }
        #endregion
    }
}
