using System.Windows.Forms;
using Client.Controller;

namespace Client.View.Diagram
{
    public partial class ViewDiagram : Form, IDiagramView
    {
        private DiagramController controller;

        public ViewDiagram()
        {
            InitializeComponent();
        }

        public void setController(DiagramController controller)
        {
            this.controller = controller;
        }

        public Panel getPanel()
        {
            return panel1;
        }
    }
}
