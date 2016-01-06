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
    public partial class OpenQuestionForm : Form
    {
        public OpenQuestionForm()
        {
            InitializeComponent();
        }

        public TableLayoutPanel getTable()
        {
            return openQuestionPanel;
        }

        public RichTextBox getTextBox()
        {
            return openQuestionTextBox;
        }

        public Button getButton()
        {
            return openQuestionBtn;
        }

        public Label getLabel()
        {
            return openQuestionLabel;
        }
    }
}
