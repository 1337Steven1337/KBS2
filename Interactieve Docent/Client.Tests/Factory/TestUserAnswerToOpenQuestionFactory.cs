using Client.Model;
using System.Collections.Generic;
using RestSharp;
using System;
using System.Net;

namespace Client.Tests.Factory
{
    public class TestUserAnswerToOpenQuestionFactory : Client.Factory.IFactory<UserAnswerToOpenQuestion>
    {
        #region Delegates
        public delegate void UserAnswerToOpenQuestionAddedDelegate(UserAnswerToOpenQuestion answer);
        public delegate void UserAnswerToOpenQuestionRemovedDelegate(UserAnswerToOpenQuestion answer);
        public delegate void UserAnswerToOpenQuestionUpdatedDelegate(UserAnswerToOpenQuestion answer);
        #endregion

        #region Events
        public event UserAnswerToOpenQuestionAddedDelegate UserAnswerToOpenQuestionAdded;
        public event UserAnswerToOpenQuestionRemovedDelegate UserAnswerToOpenQuestionRemoved;
        public event UserAnswerToOpenQuestionUpdatedDelegate UserAnswerToOpenQuestionUpdated;
        #endregion

        #region Actions
        private void OnUserAnswerToOpenQuestionAdded(UserAnswerToOpenQuestion a)
        {
            if (this.UserAnswerToOpenQuestionAdded != null)
            {
                this.UserAnswerToOpenQuestionAdded(a);
            }
        }
        private void OnUserAnswerToOpenQuestionRemoved(UserAnswerToOpenQuestion a)
        {
            if (this.UserAnswerToOpenQuestionRemoved != null)
            {
                this.UserAnswerToOpenQuestionRemoved(a);
            }
        }
        private void OnUserAnswerToOpenQuestionUpdated(UserAnswerToOpenQuestion a)
        {
            if (this.UserAnswerToOpenQuestionUpdated != null)
            {
                this.UserAnswerToOpenQuestionUpdated(a);
            }
        }
        #endregion

        public void Add(UserAnswerToOpenQuestion q)
        {
            answers.Add(q);
            UserAnswerToOpenQuestionAdded(q);
        }

        private List<UserAnswerToOpenQuestion> answers;

        public TestUserAnswerToOpenQuestionFactory()
        {
            answers = new List<UserAnswerToOpenQuestion>();
            UserAnswerToOpenQuestion a1 = new UserAnswerToOpenQuestion();
            UserAnswerToOpenQuestion a2 = new UserAnswerToOpenQuestion();
            UserAnswerToOpenQuestion a3 = new UserAnswerToOpenQuestion();
            answers.Add(a1);
            answers.Add(a2);
            answers.Add(a3);
        }

        public void DeleteAsync(UserAnswerToOpenQuestion instance, Action<UserAnswerToOpenQuestion, HttpStatusCode, IRestResponse> callback)
        {
            answers.Remove(instance);

            callback(instance, HttpStatusCode.OK, null);
        }

        public void ExecuteAsync<C>(IRestRequest request, Action<IRestResponse<C>> callback) where C : new()
        {
            throw new NotImplementedException();
        }

        public void FindAllAsync(Action<List<UserAnswerToOpenQuestion>, HttpStatusCode, IRestResponse> callback)
        {
            callback(answers, HttpStatusCode.OK, null);
        }

        public void FindByIdAsync(object id, Action<UserAnswerToOpenQuestion, HttpStatusCode, IRestResponse> callback)
        {
            callback(answers[(int)id], HttpStatusCode.OK, null);
        }

        public void SaveAsync(List<KeyValuePair<string, object>> data, Action<UserAnswerToOpenQuestion, HttpStatusCode, IRestResponse> callback)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();

            foreach (KeyValuePair<string, object> values in data)
            {
                properties.Add(values.Key, values.Value);
            }

            callback(new Model.UserAnswerToOpenQuestion(properties), HttpStatusCode.Created, null);
        }

        public void SetResource(string resource)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(List<KeyValuePair<string, object>> data, Action<UserAnswerToOpenQuestion, HttpStatusCode, IRestResponse> callback)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();

            foreach (KeyValuePair<string, object> values in data)
            {
                properties.Add(values.Key, values.Value);
            }

            callback(new Model.UserAnswerToOpenQuestion(properties), HttpStatusCode.NoContent, null);
        }
    }
}
