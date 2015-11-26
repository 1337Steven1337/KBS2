using System;
using System.Windows.Forms;
using Client.Controller;

namespace Client.View.Tabs
{
    public partial class ViewTabs : Form, ITabsView
    {
        private TabsController controller;

        public ViewTabs()
        {
            InitializeComponent();
        }

        public void setController(TabsController controller)
        {
            this.controller = controller;
        }
    }
}
