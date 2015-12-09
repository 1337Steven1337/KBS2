using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.View.Account
{
    public interface IAddAccountView : IAddView<Model.Account>
    {
        void ShowLoadFailed();
    }
}
