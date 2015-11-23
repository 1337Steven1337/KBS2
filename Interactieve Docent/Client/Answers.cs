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


namespace Client
{
    public partial class Answers : Form
    {
        private List<string> answers = new List<string>();
        private static Size startRes = new Size();
        private Question question;

        public Answers(Question question)
        {
            InitializeComponent();
            startRes.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.8);
            startRes.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.8);
            this.ClientSize = new Size(startRes.Width, startRes.Height);

            this.question = question;
        }

        private void Anwoorden_Load(object sender, EventArgs e)
        {
            List<UserAnswer> answers = this.question.UserAnswers;
//            int yes = answers.Select(answer => answer.Id == 1).ToList().Count;

//            aantalLabel1.Text = "Aantal keer ja: " + yes;
//            aantalLabel2.Text = "Aantal keer nee: ";
        }

        private void ReadAnswers()
        {
            string temp = "";
            this.AnswersTextbox.Text = temp;
        }

        private void btn_ShowAnswers_Click(object sender, EventArgs e)
        {
            
        }

        private void AnswersTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
