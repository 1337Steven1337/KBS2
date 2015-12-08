using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    public interface IAddView<T> : IView where T : AbstractModel, new()
    {
        void ShowSaveResult(T instance, HttpStatusCode status);
        void ShowSaveFailed();
        void ShowSaveSucceed();
        Model.PredefinedAnswer GetSelectedAnswer();
    }
}
