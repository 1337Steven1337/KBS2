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
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class diagram : Form
    {
        public diagram(List<int> values, List<string> answerNames, string question)
        {

            InitializeComponent();

            //add columns to the diagram
            for (int i = 0; i < answerNames.Count; i++)
            {
                chart1.Series.Add(CreateColumn(answerNames[i], values[i]));
            }
            //add question above the diagram
            textBox1.Text = question;

            Invalidate();
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

        public void updateDiagram()
        {
            Question question = Question.getById(3);
            Dictionary<string, int> questionVotes = new Dictionary<string, int>();

            foreach (PredefinedAnswer preAnswer in question.PredefinedAnswers)
            {
                if (!questionVotes.ContainsKey(preAnswer.Text))
                {
                    questionVotes[preAnswer.Text] = 0;
                }
            }

            foreach (UserAnswer answer in question.UserAnswers)
            {
                string text = question.PredefinedAnswers.Find(x => x.Id == answer.PredefinedAnswer_Id).Text;
                questionVotes[text] += 1;
            }


            List<int> votes = questionVotes.Values.ToList<int>();
            List<string> questions = questionVotes.Keys.ToList<string>();

            diagram diagram = new diagram(votes, questions, question.Text);
            diagram.Show();
        }
    }
}
