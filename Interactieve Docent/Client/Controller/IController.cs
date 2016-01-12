using Client.View;

namespace Client.Controller
{
    public interface IController
    {
        IView GetView();
        void SetView(IView view);
    }
}
