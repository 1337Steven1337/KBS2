using Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Service.Thread
{
    public class ControlHandler : IControlHandler
    {
        private Control control;

        public ControlHandler(Control control)
        {
            this.control = control;
        }

        public void Invoke(Delegate action)
        {
            control.Invoke(action);
        }

        public void Invoke(Delegate action, params object[] args)
        {
            control.Invoke(action, args);
        }
    }
}
