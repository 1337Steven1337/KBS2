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
using Client.Service.SignalR;
using Client.Service.Thread;

namespace Client.View.Docent
{
    public partial class DocentOmgevingView : Form, IView
    {

        public DocentOmgevingView()
        {

            InitializeComponent();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            SignalRClient.GetInstance().GoToNextQuestionOnClick(1);
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void QuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
