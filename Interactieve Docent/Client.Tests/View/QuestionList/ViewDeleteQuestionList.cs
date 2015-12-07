﻿using System;
using System.Windows.Forms;

namespace Client.Tests.View.Question
{
    public partial class ViewDeleteQuestionList
    {
        public Boolean valid { get; set; }
        public string Text { private set; get; }

        public ViewDeleteQuestionList()
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
