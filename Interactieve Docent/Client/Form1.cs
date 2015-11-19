using Client.API;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Question> q = Question.getAll();
            foreach (Question fag in q)
            {
                Console.WriteLine("-----" + fag.Text  + "-----");
                foreach (PredefinedAnswer p in fag.PredefinedAnswers)
                {
                    Console.WriteLine(p.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question q = Question.getById(3);
            Console.WriteLine(q.Text);
            //UserAnswer ua = UserAnswer.getById(1);
            //Console.WriteLine(ua.PredefinedAnswer.Text);
        }
    }
}
