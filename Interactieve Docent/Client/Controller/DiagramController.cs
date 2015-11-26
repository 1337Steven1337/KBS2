using Client.View.Diagram;
using System.Windows.Forms;

namespace Client.Controller
{
    public class DiagramController
    {
        IDiagramView view;
        Panel panel;

        public DiagramController(IDiagramView view, Panel panel)
        {
            this.panel = panel;
            this.view = view;
            this.view.setController(this);

            panel.Controls.Add(view.getPanel());
        }
    }
}
