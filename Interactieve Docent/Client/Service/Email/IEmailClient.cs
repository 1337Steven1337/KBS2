using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service.Email
{
    public interface IEmailClient
    {
        void Send(string student, string password);
    }
}
