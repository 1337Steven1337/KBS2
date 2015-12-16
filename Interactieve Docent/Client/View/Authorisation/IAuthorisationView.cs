using Client.Controller;
using Client.Service.Thread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model;
using RestSharp;
using System.Net;

namespace Client.View
{
    public interface IAuthorisationView : IView
    {
        void ShowAuthorisationResult(Model.Account ac, HttpStatusCode status);
    }
}
