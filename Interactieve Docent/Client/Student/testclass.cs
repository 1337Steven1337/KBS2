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
using Client.API.Models;

namespace Client
{
    public enum State
    {
        visible,
        invisible
    }

    public partial class testclass : Form
    {

        //De questionID is om de vraag uit de database te halen alsmede het antwoord
        public int questionID { get; set; }
        public int ListId { get; set; }
        Timer countdown = new Timer();
        List<Question> Vragen = new List<Question>();
        static int ButtonCounter = 0;
        static int ButtoncounterHorizontal = -1;
        static int QuestionListCounter = 0;
        Label QuestionLabel;
        static int KeepTrackOfTimer = 0;
        Button nee;
        List<Button> ButtonList;
        Button ja;
        //example timeleft
        static int testTime = 1000;
        int CopyTestTime = testTime;
        State previousState;
        static int ButtonCounterVertical;
        string vraagtext { get; set; }
        bool ProgressbarIsAllowed = false;
        ProgressBar DoWeStillHaveTime;
        //0 is question known 1 is question unknown
        static int KeepTrackOfQuestion = 0;
        int howMuch;
        public ListBox listbox;



        public testclass()
        {
            //InitializeComponent();
            countdown.Interval = 1;
            countdown.Tick += countdown_Tick;

            //testwaardes
            //Vragen.Add("test1");
            //Vragen.Add("test2");
            //vraaglabel
            QuestionLabel = new Label();
            QuestionLabel.Width = Width;
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



            DoWeStillHaveTime = progress();
            questionID = 1;
            foreach (Question q in GetQuestionFromDB(questionID))
            {
                Vragen.Add(q);
            }
            Controls.Add(DoWeStillHaveTime);
            Controls.Add(nee);
            Controls.Add(ja);


            countdown.Start();
            //InitializeComponent();
        }

        public List<Question> GetQuestionFromDB(int id)
        {
            List<Question> questions = List.getById(id).Questions;
            return questions;
        }

        //eventhandler countdown timer
        private void countdown_Tick(Object myObject, EventArgs myEventArgs)
        {
            if (ProgressbarIsAllowed == true)
            {
                DoWeStillHaveTime.Text = howMuch.ToString();
                DoWeStillHaveTime.PerformStep();
                if (KeepTrackOfTimer >= testTime)
                {
                    ProgressbarIsAllowed = false;
                    KeepTrackOfTimer = -1;
                    //vraag();
                    if (ButtonList[0].Visible == true)
                    {
                        //Debug.WriteLine("De buttonlist[0] versie!"); b
                       //  isValidQuestion();
                    }
                }
                KeepTrackOfTimer++;

                if (KeepTrackOfTimer % 100 == 0)
                {

                }

            }
            Invalidate();
        }


        private string vraag()
        {
            //loopen door de lijst
            if (QuestionListCounter < Vragen.Count())
            {
                this.vraagtext = Vragen[QuestionListCounter++].Text;

                int questionID2 = Vragen[QuestionListCounter].Id;
                Debug.WriteLine("Answers = " + PredefinedAnswer.getById(questionID2).Text);
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
                    if (ButtonList != null)
                    {
                        foreach (Button button in ButtonList)
                        {
                            button.Visible = false;
                        }

                        DoWeStillHaveTime.Visible = false;
                    }


                }

            }

            return vraagtext;
        }

        private Button options(string text)
        {



            Button option = new Button();
            option.Text = text;
            option.Location = new Point(Width / 2 + option.Width * (ButtoncounterHorizontal), Height - option.Height * (4 - ButtonCounterVertical));
            ButtonCounter++;
            if (ButtonCounter % 2 == 0)
            {
                ButtonCounterVertical++;
                ButtonCounter = 0;
            }
            if (ButtoncounterHorizontal <= 0)
            {
                ButtoncounterHorizontal += 1;
            }
            else
            {
                ButtoncounterHorizontal = -1;
            }
            //buttonlist populeren!
            ButtonList.Add(option);
            return option;
        }

        private ProgressBar progress()
        {
            ProgressBar SecondsLeft = new ProgressBar();
            SecondsLeft.Location = new System.Drawing.Point(0, 243);
            SecondsLeft.Name = "Time";
            SecondsLeft.Size = new System.Drawing.Size(Width, 23);
            SecondsLeft.TabIndex = 0;
            SecondsLeft.Maximum = testTime;

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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // testclass
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "testclass";
            this.Load += new System.EventHandler(this.testclass_Load);
            this.ResumeLayout(false);

        }

        private void testclass_Load(object sender, EventArgs e)
        {

        }
    }
}