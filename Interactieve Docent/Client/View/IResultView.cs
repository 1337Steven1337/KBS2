﻿using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    interface IResultView<T> : IView where T : AbstractModel, new()
    {
        void ShowSaveQuestionListResult(T instance, HttpStatusCode status);
        void ShowDeleteQuestionListResult(T instance, HttpStatusCode status);
        void ShowDeleteQuestionResult(T instance, HttpStatusCode status);
        void FillList(List<T> list);
        void AddItem(T item);
        void DeleteItem(T item);
        Model.OpenQuestion getSelectedItem();
        void Show();
        void Close();
        void Refresh(List<UserAnswerToOpenQuestion> answers, Model.OpenQuestion question);
        void setText(string text);
    }
}
