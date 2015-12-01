using Client.Controller;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.View.Diagram
{
    public interface IDiagramView
    {
        void setController(DiagramController controller);
        void Make(List<int> values, List<string> answerNames, string question);
        void Show();
        Panel getPanel();
    }
}
