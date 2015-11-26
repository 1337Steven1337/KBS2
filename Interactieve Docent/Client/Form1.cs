using Client.API.Models;
using Client.Student;
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
        public int Question_Id;
        public int List_Id;
        public Form1()
        {
            InitializeComponent();

            foreach (Question text in Question.getAll())
            {
                comboBox1.Items.Add(text.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > -1)
            {
                this.Question_Id = comboBox1.SelectedIndex + 1;
            }
            else
            {
                this.Question_Id = 3;
            }
            
            diagram diagram = new diagram(this.Question_Id);
            diagram.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocentControlUI docentControlUI = new DocentControlUI();
            docentControlUI.Show();
        }

    }
}
