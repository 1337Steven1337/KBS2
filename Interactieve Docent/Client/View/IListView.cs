using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    public interface IListView<T> : IView where T : AbstractModel, new()
    {
        void ShowSaveQuestionListResult(T instance, HttpStatusCode status);        
        void ShowDeleteQuestionListResult(T instance, HttpStatusCode status);
        void ShowDeleteQuestionResult(T instance, HttpStatusCode status);
        void ShowUpdateQuestionListResult(T instance, HttpStatusCode status);
        void FillList(List<T> list);
        void AddItem(T item);
        void DeleteItem(T item);
        Model.Question getSelectedItem();
    }
}
