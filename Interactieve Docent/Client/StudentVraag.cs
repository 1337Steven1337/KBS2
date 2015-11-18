using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public enum State
    {
        visible,
        invisible
    }

    public partial class StudentVraag : Form
    {
        Timer countdown = new Timer();
        List<string> Vragen = new List<string>();
        static int ButtonCounter = 0;
        static int QuestionListCounter = 0;
        Label QuestionLabel;
        Button nee;
        Button ja;
        State previousState;
        static int ButtonCounterVertical;
        string vraagtext { get; set; }

        public StudentVraag()
        {
            InitializeComponent();
            countdown.Interval = 1000;
            //testwaardes
            Vragen.Add("test1");
            Vragen.Add("test2");
            Vragen.Add("test3");
            Vragen.Add("test4");
            Vragen.Add("test5");
            Vragen.Add("test6");
            //vraaglabel
            QuestionLabel = new Label();
            QuestionLabel.AutoSize = false;
            QuestionLabel.Text = vraag();
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(QuestionLabel);
            //vaste knoppen
            ja = options("ja");
            nee = options("nee");
            nee.Click += button_click;
            ja.Click += button_click;
            Controls.Add(nee);
            Controls.Add(ja);

            InitializeComponent();
        }

        private string vraag()
        {
            if (QuestionListCounter < Vragen.Count())
            {
                this.vraagtext = Vragen[QuestionListCounter++];

            }
            else
            {
                vraagtext = null;
                QuestionListCounter = 0;
            }




            return vraagtext;
        }

        private Button options(string text)
        {


            Button option = new Button();
            option.Text = text;
            option.Location = new Point(option.Width * ButtonCounter, Height - option.Height * (4 - ButtonCounterVertical));
            ButtonCounter++;
            if (ButtonCounter % 2 == 0)
            {
                ButtonCounterVertical++;
                ButtonCounter = 0;
            }
            return option;
        }

        private void button_click(object sender, EventArgs e)
        {

            if (vraagtext != null)
            {
                QuestionLabel.Text = vraag();
                if (previousState == State.invisible)
                {
                    ja.Visible = true;
                    nee.Visible = true;
                    previousState = State.visible;
                }
            }
            else
            {
                if (previousState == State.visible)
                {
                    ja.Visible = false;
                    nee.Visible = false;
                    previousState = State.invisible;
                }
            }


            QuestionLabel.Refresh();
            Application.DoEvents();
        }
    }
}
