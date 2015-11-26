using Client.View.Tabs;

namespace Client.Controller
{
    public class TabsController
    {
        ITabsView view;

        public TabsController(ITabsView view)
        {
            this.view = view;
            this.view.setController(this);
        }
    }
}
