using Client.API.Models;
using Client.Controller;
using Client.Factory;
using Client.Model;
using Client.Service.SignalR;
using Client.Student;
using Client.View.Diagram;
using Microsoft.AspNet.SignalR;
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
        private QuestionListFactory qlf = new QuestionListFactory();

        public Form1()
        {
            InitializeComponent();

            /**foreach (Question text in Question.getAll())
            {
                comboBox1.Items.Add(text.Text);
            }*///
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SignalRClient client = SignalRClient.GetInstance();
            client.subscriptionStatusChanged += Client_subscriptionStatusChanged;
            qlf = new QuestionListFactory();
            qlf.QuestionListAdded += Qlf_questionListAdded;
        }

        private void Qlf_questionListAdded(QuestionList list)
        {
            throw new NotImplementedException();
        }

        private void Client_subscriptionStatusChanged(Service.SignalR.EventArgs.SubscriptionStatus message)
        {
            QuestionList ql = new QuestionList();
            ql.Name = "Test list 99999";
            ql.Ended = false;

            //qlf.Save(ql, null);
        }

        private void test(QuestionList list)
        {
            Console.WriteLine("List fetched");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**if(comboBox1.SelectedIndex > -1)
            {
                this.Question_Id = comboBox1.SelectedIndex + 1;
            }
            else
            {
                this.Question_Id = 3;
            }
            
            diagram diagram = new diagram(this.Question_Id);
            diagram.Show();**/

            QuestionListFactory factory = new QuestionListFactory();
            Console.WriteLine("Before fetch");
            factory.FindByIdAsync(2, test);
            Console.WriteLine("After fetch");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DocentControlUI docentControlUI = new DocentControlUI();
            //docentControlUI.Show();
        }

    }
}
