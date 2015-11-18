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
        private int countJa, countNee;


        public Answers()
        {
            InitializeComponent();
            startRes.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.8);
            startRes.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.8);
            this.ClientSize = new Size(startRes.Width, startRes.Height);
        }

        private void Anwoorden_Load(object sender, EventArgs e)
        {
            aantalLabel1.Text = "Aantal keer ja: ";
            aantalLabel2.Text = "Aantal keer nee: ";

            answers.Add("JA");
            answers.Add("JA");
            answers.Add("NEE");
            answers.Add("NEE");
            answers.Add("JA");
            answers.Add("NEE");
        }

        private void ReadAnswers()
        {
            string temp = "";
            foreach (String a in answers)
            {
                temp += a + "\n";
            }
            this.AnswersTextbox.Text = temp;
        }

        private void ReadAnswersYes()
        {
            foreach (String a in answers)
            {
                if (a == "JA" || a == "Ja" || a == "ja")
                {
                    countJa++;
                }
            }
            aantalLabel1.Text += countJa;
        }

        private void ReadAnswersNo()
        {
            foreach (String a in answers)
            {
                if (a == "NEE" || a == "Nee" || a == "nee")
                {
                    countNee++;
                }
            }
            aantalLabel2.Text += countNee;
        }

        private void btn_ShowAnswers_Click(object sender, EventArgs e)
        {
            ReadAnswers();
            ReadAnswersYes();
            ReadAnswersNo();
        }
    }
}
