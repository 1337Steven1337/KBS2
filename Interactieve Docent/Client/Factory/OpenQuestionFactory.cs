 using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Factory
{
    public class OpenQuestionFactory : AbstractFactory<Model.OpenQuestion>
    {
        #region Delegates
        public delegate void OpenQuestionAddedDelegate(OpenQuestion openQuestion);
        public delegate void OpenQuestionRemovedDelegate(OpenQuestion openQuestion);
        public delegate void OpenQuestionUpdatedDelegate(OpenQuestion openQuestion);
        #endregion

        #region Events
        public event OpenQuestionAddedDelegate OpenQuestionAdded;
        public event OpenQuestionRemovedDelegate OpenQuestionRemoved;
        public event OpenQuestionUpdatedDelegate OpenQuestionUpdated;
        #endregion

        #region Properties
        protected override string Resource
        {
            get
            {
                return "OpenQuestions";
            }
        }
        #endregion

        #region Constructors
        public OpenQuestionFactory() : base(new BaseFactory<OpenQuestion>())
        {
            this.SignalRClient.proxy.On<OpenQuestion>("OpenQuestionAdded", this.OnOpenQuestionAdded);
            this.SignalRClient.proxy.On<OpenQuestion>("OpenQuestionRemoved", this.OnOpenQuestionRemoved);
            this.SignalRClient.proxy.On<OpenQuestion>("OpenQuestionUpdated", this.OnOpenQuestionUpdated);
        }
        #endregion

        #region Actions
        private void OnOpenQuestionAdded(OpenQuestion q)
        {
            if (this.OpenQuestionAdded != null)
            {
                this.OpenQuestionAdded(q);
            }
        }
        private void OnOpenQuestionRemoved(OpenQuestion q)
        {
            if (this.OpenQuestionRemoved != null)
            {
                this.OpenQuestionRemoved(q);
            }
        }
        private void OnOpenQuestionUpdated(OpenQuestion q)
        {
            if (this.OpenQuestionUpdated != null)
            {
                this.OpenQuestionUpdated(q);
            }
        }
        #endregion

        #region Overrides
        protected override Dictionary<string, object> GetFields(OpenQuestion question)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", question.Text);
            values.Add("Pincode_Id", question.Pincode_Id);

            return values;
        }

        protected override Dictionary<string, object> UpdateFields(OpenQuestion instance)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
