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
        void ShowNoAccountsFound();
        void ShowSaveFailed(Dictionary<string, int> data);
        void ResetProgressBar(int step, int maxValue);
        void UpdateProgressBar();
        void EnableButton();
        void DisableButton();
    }
}
