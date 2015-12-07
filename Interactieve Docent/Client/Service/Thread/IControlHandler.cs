using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Service.Thread
{
    public interface IControlHandler
    {
        void Invoke(Delegate action);
        void Invoke(Delegate action, params object[] args);
    }
}
