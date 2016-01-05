using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    public interface IResultView<T> : IView where T : AbstractModel, new()
    {
        void FillList(List<T> list);
        void Show();
        void Close();
        void Refresh(List<UserAnswerToOpenQuestion> answers, Model.OpenQuestion question);
        void setText(string text);
    }
}
