using System;

namespace Client.Service.Thread
{
    public interface IControlHandler
    {
        void Invoke(Delegate action);
        void Invoke(Delegate action, params object[] args);
    }
}
