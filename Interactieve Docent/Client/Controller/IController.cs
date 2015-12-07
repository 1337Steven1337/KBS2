using Client.Factory;
using Client.Model;
using Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    public interface IController
    {
        IView GetView();
        void SetView(IView view);
    }
}
