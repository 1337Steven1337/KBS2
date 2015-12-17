using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;

namespace Client.View.OpenQuestion
{
    public partial class AddOpenQuestionView : Form, IAddView<Model.OpenQuestion>
    {
        public AddOpenQuestionView()
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

        public PredefinedAnswer GetSelectedAnswer()
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            
        }

        public void ShowSaveFailed()
        {
            throw new NotImplementedException();
        }

        public void ShowSaveResult(Model.OpenQuestion instance, HttpStatusCode status)
        {
            throw new NotImplementedException();
        }

        public void ShowSaveSucceed()
        {
            throw new NotImplementedException();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
