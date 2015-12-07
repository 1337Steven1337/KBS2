using Client.Controller;
using Client.Service.Thread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    public interface IView
    {
        IControlHandler GetHandler();
        void AddToParent(IView parent);
        void SetController(IController controller);
    }
}
