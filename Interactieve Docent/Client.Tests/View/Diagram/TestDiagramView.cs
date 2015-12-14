using Client.View.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;
using System.Windows.Forms;
using Client.Service.Thread;
using Client.View;

namespace Client.Tests.View.Diagram
{
    class TestDiagramView : IDiagramView
    {
        public void AddToParent(IView parent)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public IControlHandler GetHandler()
        {
            throw new NotImplementedException();
        }

        public void Make(List<int> values, List<string> answerNames, string question)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }

        public void setController(DiagramController controller)
        {
            throw new NotImplementedException();
        }

        public void setPanel<T>(Panel panel)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
