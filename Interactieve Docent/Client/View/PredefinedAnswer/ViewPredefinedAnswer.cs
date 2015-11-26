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

namespace Client.View.PredefinedAnswer
{
    public partial class ViewPredefinedAnswer : Form, IPredefinedAnswerView
    {
        private PredefinedAnswerController Controller;

        public ViewPredefinedAnswer()
        {
            InitializeComponent();
        }

        public void setController(PredefinedAnswerController Controller)
        {
            this.Controller = Controller
        }
    }
}
