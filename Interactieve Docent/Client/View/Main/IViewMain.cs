using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;

namespace Client.View.Main
{
    public interface IViewMain : IView
    {
        void setController(MainController controller);

    }
}
