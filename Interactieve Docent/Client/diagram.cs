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
        public List<string> questions;
        public List<int> votes;
        Dictionary<string, int> questionVotes = new Dictionary<string, int>();
        public Question question;

        public diagram()
        {
            InitializeComponent();
            GetData();
            MakeDiagram(votes, questions, question.Text);
            Invalidate();
        }

        public void MakeDiagram(List<int> values, List<string> answerNames, string question)
        {
            //add columns to the diagram
            for (int i = 0; i < this.answerNames.Count; i++)
            {
                chart1.Series.Add(CreateColumn(this.answerNames[i], this.values[i]));
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
            //select a question
            question = Question.getById(3);
            

            //if the predefinedanswer is empty zet votes to zero
            foreach (PredefinedAnswer preAnswer in question.PredefinedAnswers)
            {
                if (!questionVotes.ContainsKey(preAnswer.Text))
                {
                    questionVotes[preAnswer.Text] = 0;
                }
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

        private void OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency dependency = sender as SqlDependency;

            // Notices are only a one shot deal so remove the existing one so a new one can be added

            dependency.OnChange -= OnChange;

            // Fire the event
            diagram();

        }
        
    }
}
