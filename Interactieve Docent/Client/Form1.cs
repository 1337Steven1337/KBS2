using Client.API;
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
    public partial class Form1 : Form
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
            Question question = Question.getById(3);
            Answers answer = new Answers(question);
            answer.Show();
            Console.WriteLine("Hallo");

            List lists = List.getById(1);

            Console.WriteLine(lists.Name);
        }
    }
}
