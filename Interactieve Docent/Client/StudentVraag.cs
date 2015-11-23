using System;
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
        static int KeepTrackOfTimer = 0;
        Button nee;
        List<Button> ButtonList;
        Button ja;
        //example timeleft
        static int testTime = 10;
        int CopyTestTime = testTime;
        State previousState;
        static int ButtonCounterVertical;
        string vraagtext { get; set; }
        bool ProgressbarIsAllowed = false;
        ProgressBar DoWeStillHaveTime;
        //0 is question known 1 is question unknown
        static int KeepTrackOfQuestion = 0;


        public StudentVraag()
        {
            InitializeComponent();
            countdown.Interval = 200;
            countdown.Tick += countdown_Tick;

            //testwaardes
            Vragen.Add("test1");
            Vragen.Add("test2");
            //vraaglabel
            QuestionLabel = new Label();
            QuestionLabel.Width = Width;
            //QuestionLabel.AutoSize = false;
            DoWeStillHaveTime = progress();
            QuestionLabel.Text = vraag();
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            //lijst van buttons
            ButtonList = new List<Button>();
            Controls.Add(QuestionLabel);
            //vaste knoppen
            ja = options("ja");
            nee = options("nee");
            nee.Click += button_click;
            ja.Click += button_click;

            Controls.Add(DoWeStillHaveTime);
            Controls.Add(nee);
            Controls.Add(ja);
            countdown.Start();
            InitializeComponent();
        }

        //eventhandler countdown timer
        private void countdown_Tick(Object myObject, EventArgs myEventArgs)
        {
            Debug.WriteLine(vraagtext);
            if (ProgressbarIsAllowed == true)
            {

                DoWeStillHaveTime.PerformStep();
                if (KeepTrackOfTimer > testTime)
                {
                    //Debug.WriteLine(KeepTrackOfTimer);
                    ProgressbarIsAllowed = false;
                    KeepTrackOfTimer = -1;
                    //vraag();
                    if (ButtonList[0].Visible == true)
                    {
                        Debug.WriteLine("De buttonlist[0] versie!");
                        isValidQuestion();
                    }
                }
                KeepTrackOfTimer++;
            }
            Invalidate();
        }


        private string vraag()
        {
            //loopen door de lijst
            if (QuestionListCounter < Vragen.Count())
            {
                this.vraagtext = Vragen[QuestionListCounter++];
                DoWeStillHaveTime.Value = 0;
                ProgressbarIsAllowed = true;
                if (previousState == State.invisible)
                {

                    ja.Visible = true;
                    nee.Visible = true;
                    previousState = State.visible;
                }

            }
            else
            {
                vraagtext = "Wachten op vraag van leraar...";
                if (previousState == State.visible)
                {

                    previousState = State.invisible;

                    foreach (Button button in ButtonList)
                    {
                        button.Visible = false;
                    }
                    DoWeStillHaveTime.Visible = false;

                }

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
            //buttonlist populeren!
            ButtonList.Add(option);
            Debug.WriteLine(ButtonList.Count);
            return option;
        }

        private ProgressBar progress()
        {
            ProgressBar SecondsLeft = new ProgressBar();
            SecondsLeft.Location = new System.Drawing.Point(288, 243);
            SecondsLeft.Name = "Time";
            SecondsLeft.Size = new System.Drawing.Size(208, 23);
            SecondsLeft.TabIndex = 0;
            SecondsLeft.Maximum = testTime;
            SecondsLeft.BackColor = Color.Red;

            SecondsLeft.ForeColor = Color.Blue;
            SecondsLeft.RightToLeftLayout = false;
            SecondsLeft.Step = 1;

            return SecondsLeft;
        }

        private void isValidQuestion()
        {
            Debug.WriteLine("Voor de Isvalid Functie:" + QuestionLabel.Text);
            if (KeepTrackOfQuestion == 0)
            {
                if (DoWeStillHaveTime.Visible == false)
                {
                    DoWeStillHaveTime.Visible = true;
                }
                QuestionLabel.Text = vraag();


                //return;

            }

            QuestionLabel.Refresh();
            Application.DoEvents();
        }



        private void button_click(object sender, EventArgs e)
        {

            isValidQuestion();

        }
    }
}
