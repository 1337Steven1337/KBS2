using System;
using System.Windows.Forms;

namespace Client.Tests.View.Question
{
    public partial class ViewDeleteQuestion
    {
        public Boolean valid { get; set; }
        private string Text;

        public ViewDeleteQuestion()
        {
            valid = false;
        }

        public void buttonOk_Click()
        {
            valid = true;
        }

        public void buttonCancel_Click()
        {
        }

        public void setText(string text)
        {
            Text = text;
        }
    }
}
