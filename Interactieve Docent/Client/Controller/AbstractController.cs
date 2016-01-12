using Client.View;
using Client.Factory;
using Client.Model;

namespace Client.Controller
{ 
    public abstract class AbstractController<T> : IController where T : AbstractModel, new()
    {
        public Factory.IFactory<T> BaseFactory { get; set; }

        public abstract IView GetView();
        public abstract void SetView(IView view);

        public abstract void SetBaseFactory(IFactory<T> baseFactory);
    }
}
