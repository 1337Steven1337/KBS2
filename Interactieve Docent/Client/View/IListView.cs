using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    public interface IListView<T> : IView where T : AbstractModel, new()
    {
        void FillList(List<T> list);
        void AddItem(T item);
    }
}
