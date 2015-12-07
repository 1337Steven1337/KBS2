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
        IControlHandler getHandler();
        void AddToParent(IView parent);
    }
}
