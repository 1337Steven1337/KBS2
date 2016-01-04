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
using Client.Controller.Question;
using Client.Service.SignalR;
using Client.Service.Thread;

namespace Client.View.Docent
{
    public partial class DocentOmgevingView : Form, IView
    {
        private DocentOmgevingController controller;

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
            this.controller = (DocentOmgevingController)controller;
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            SignalRClient.GetInstance().GoToNextQuestionOnClick(1);
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestionController a = new AddQuestionController();
        }

        private void QuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
