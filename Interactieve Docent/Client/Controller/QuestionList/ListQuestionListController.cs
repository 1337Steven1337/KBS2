using Client.View;
using Client.View.QuestionList;
using Client.Factory;
using System.Collections.Generic;
using System.Net;
using Client.Model;
using RestSharp;
using System;

namespace Client.Controller.QuestionList
{
    public class ListQuestionListController : AbstractController<Model.QuestionList>
    {
        #region Delegates
        public delegate void SelectedListChangedDelegate(Model.QuestionList question);
        #endregion

        #region Events
        public event SelectedListChangedDelegate SelectedListChanged;
        #endregion

        #region Instances
        private IListView<Model.QuestionList> View { get; set; }
        private QuestionListFactory Factory = new QuestionListFactory();
        #endregion

        #region Constructors
        public ListQuestionListController(IView view) 
        {
            this.SetView(view);
            view.SetController(this);
        }
        #endregion

        #region Methods
        public void Load()
        {
            this.Factory.FindAll(this.View.GetHandler(), this.FillList);
        }

        public void SelectedIndexChanged(Model.QuestionList list)
        {
            if (this.SelectedListChanged != null)
            {
                this.SelectedListChanged(list);
            }
        }

        private void FillList(List<Model.QuestionList> list, HttpStatusCode code)
        {
            if (code == HttpStatusCode.OK && list != null)
            {
                this.View.FillList(list);
            }
        }
        #endregion

        #region Overrides
        public override IView GetView()
        {
            return this.View;
        }

        public override void SetView(IView view)
        {
            this.View = (IListView<Model.QuestionList>)view;
        }

        public override void SetBaseFactory(IFactory<Model.QuestionList> factory)
        {
            this.Factory.SetBaseFactory(factory);
        }

        public void SaveQuestionList(Dictionary<string, object> data)
        {
            Model.QuestionList list = new Model.QuestionList(data);
            ListQuestionListView view = (ListQuestionListView)this.View;
            this.Factory.Save(list, this.View.GetHandler(), CallbackSaveQuestionlist);
        }

        private void CallbackSaveQuestionlist(Model.QuestionList list, HttpStatusCode status)
        {
            this.View.ShowSaveQuestionListResult(list, status);
        }

        public void DeleteQuestionList(Model.QuestionList list)
        {
            ListQuestionListView view = (ListQuestionListView)this.View;
            this.Factory.Delete(list, this.View.GetHandler(), CallbackDeleteQuestionList);
        }

        private void CallbackDeleteQuestionList(Model.QuestionList list, HttpStatusCode status)
        {
            this.View.ShowDeleteQuestionListResult(list, status);                        
        }
        #endregion
    }
}
