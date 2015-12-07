using Client.Service.Thread;
using System;
using System.Threading.Tasks;

namespace Client.Tests
{
    public class TestControlHandler : IControlHandler
    {
        public void Invoke(Delegate action)
        {
            action.DynamicInvoke();
        }

        public void Invoke(Delegate action, params object[] args)
        {
            action.DynamicInvoke(args);
        }
    }
}
