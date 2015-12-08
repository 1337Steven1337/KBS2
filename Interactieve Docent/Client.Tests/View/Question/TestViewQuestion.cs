using Client.View.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;
using Client.Model;
using Client.Service.Thread;
using Client.View;
using System.Windows.Forms;

namespace Client.Tests.View.Question
{
    class TestViewQuestion : IListView<Model.Question>
    {
        public void AddItem(Model.Question item)
        {
            throw new NotImplementedException();
        }

        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void FillList(List<Model.Question> list)
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
    }
}
