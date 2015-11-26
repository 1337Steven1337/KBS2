using Client.Controller;
using System.Windows.Forms;

namespace Client.View.Diagram
{
    public interface IDiagramView
    {
        void setController(DiagramController controller);
        Panel getPanel();
    }
}
