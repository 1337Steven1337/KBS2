using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;

namespace Client.View.Question
{
    public partial class ViewQuestion : Form, IQuestionView
    {
        private QuestionController controller;

        public ViewQuestion()
        {
            InitializeComponent();
        }

        public void setController(QuestionController controller)
        {
            this.controller = controller;
        }


    }
}
