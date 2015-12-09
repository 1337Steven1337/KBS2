using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Tests.View.QuestionList
{
    class TestViewAddQuestionList
    {
        public string text { private set; get; }
        public Boolean valid { private set; get; }

        public TestViewAddQuestionList()
        {
            text = "";
            valid = false;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void Ok()
        {
            if(text.Length > 0)
            {
                valid = true;
            }
        }
    }
}
