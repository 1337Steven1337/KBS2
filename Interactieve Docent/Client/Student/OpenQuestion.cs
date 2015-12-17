using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Student
{
    public partial class OpenQuestion : Form
    {
        public OpenQuestion()
        {
            InitializeComponent();
            Label QuestionLabel = OpenQuestionController.Addlabel("Welk gevoel krijg jij bij het woord banaan?");
            TextBox textbox = OpenQuestionController.AddTextBox(Width,Height);
            Button button = OpenQuestionController.AddButton(Width, Height);
            QuestionLabel.Location = new Point((Width / 2) - (QuestionLabel.Width / 2));
            Controls.Add(button);
            Controls.Add(QuestionLabel);
            Controls.Add(textbox);
            InitializeComponent();
        }
    }
}
