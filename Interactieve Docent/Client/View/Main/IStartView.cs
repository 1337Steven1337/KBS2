using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.View.Main
{
    public interface IStartView : IView
    {
        void ShowCodeResult(Model.Pincode instance, HttpStatusCode status);
    }
}
