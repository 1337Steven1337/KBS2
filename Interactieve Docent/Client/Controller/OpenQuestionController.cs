using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    class OpenQuestionController
    {
        public static Label Addlabel(string Question)
        {
            Label QuestionLabel = new Label();
            int center = 0;
            QuestionLabel.AutoSize = false;
            QuestionLabel.TextAlign = ContentAlignment.TopCenter;
            QuestionLabel.AutoSize = true;


            //QuestionLabel.Dock = DockStyle.Fill;
            QuestionLabel.Font = new Font(QuestionLabel.Font.FontFamily, 22);
            QuestionLabel.Text = Question;
            QuestionLabel.Width = QuestionLabel.PreferredWidth;
            Debug.WriteLine(QuestionLabel.PreferredWidth);


            return QuestionLabel;
        }

        public static TextBox AddTextBox(int width, int heigth)
        {
            int heiggthOfTextbox = (heigth / 100) * 50;
            Rectangle rectangle = new Rectangle(10, heiggthOfTextbox, width, heigth);
            TextBox Answerbox = new TextBox();
            Answerbox.Multiline = true;
            Answerbox.Width = width - 60;
            Answerbox.Height = heiggthOfTextbox;
            Answerbox.Location = new Point(20, heiggthOfTextbox - (heiggthOfTextbox/5)*2);
            //Answerbox.RectangleToClient(rectangle);
            return Answerbox;
        }

        public static Button AddButton(int width, int heigth)
        {
            Button SaveButton = new Button();
            SaveButton.Text = "Opslaan";
            SaveButton.Size = new Size(80,50);
            SaveButton.Location = new Point(width - 100, heigth - 100);
            return SaveButton;
        }

    }
}
