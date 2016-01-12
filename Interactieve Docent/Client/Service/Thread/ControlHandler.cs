using System;
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
