using Client.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Factory
{
    public class PredefinedAnswerFactory : AbstractFactory
    {
        #region Delegates
        public delegate void PredefinedAnswerAdded(PredefinedAnswer answer);
        public delegate void PredefinedAnswerRemoved(PredefinedAnswer answer);
        public delegate void PredefinedAnswerUpdated(PredefinedAnswer answer);
        #endregion

        #region Events
        public event PredefinedAnswerAdded predefinedAnswerAdded;
        public event PredefinedAnswerRemoved predefinedAnswerRemoved;
        public event PredefinedAnswerUpdated predefinedAnswerUpdated;
        #endregion

        #region Constants
        private const string resource = "PredefinedAnswers";
        #endregion

        #region Constructors
        public PredefinedAnswerFactory()
        {
            this.signalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerAdded", this.onPredefinedAnswerAdded);
            this.signalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerRemoved", this.onPredefinedAnswerRemoved);
            this.signalRClient.proxy.On<PredefinedAnswer>("PredefinedAnswerUpdated", this.onPredefinedAnswerUpdated);
        }
        #endregion

        #region Actions
        private void onPredefinedAnswerAdded(PredefinedAnswer a)
        {
            if (this.predefinedAnswerAdded != null)
            {
                this.predefinedAnswerAdded(a);
            }
        }

        private void onPredefinedAnswerRemoved(PredefinedAnswer a)
        {
            if (this.predefinedAnswerRemoved != null)
            {
                this.predefinedAnswerRemoved(a);
            }
        }

        private void onPredefinedAnswerUpdated(PredefinedAnswer a)
        {
            if (this.predefinedAnswerUpdated != null)
            {
                this.predefinedAnswerUpdated(a);
            }
        }
        #endregion

        #region Thread unaware methods
        /// <summary>
        /// Deletes the answer from the database
        /// </summary> 
        /// <param name="answer">The answer to delete</param>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void deleteAsync(PredefinedAnswer answer, Action<PredefinedAnswer> callback)
        {
            this.deleteAsync<PredefinedAnswer>(answer.Id, resource, callback);
        }

        /// <summary>
        /// Saves the answer to the database
        /// </summary>
        /// <param name="answer">The answer to save</param>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void saveAsync(PredefinedAnswer answer, Action<PredefinedAnswer> callback)
        {
            this.saveAsync<PredefinedAnswer>(this.getFields(answer), resource, callback);
        }

        /// <summary>
        /// Finds an instance of the answer model by id
        /// </summary>
        /// <param name="id">The ID of the instance</param>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void findByIdAsync(int id, Action<PredefinedAnswer> callback)
        {
            this.findByIdAsync<PredefinedAnswer>(id, resource, callback);
        }

        /// <summary>
        /// Finds all instances of the answer model
        /// </summary>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void findAllAsync(Action<List<PredefinedAnswer>> callback)
        {
            this.findAllAsync<PredefinedAnswer>(resource, callback);
        }
        #endregion

        #region Thread aware methods
        /// <summary>
        /// Deletes the answer from the database
        /// </summary>
        /// <param name="answer">The answer to delete</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void delete(PredefinedAnswer answer, Control control, Action<PredefinedAnswer> callback)
        {
            this.delete<PredefinedAnswer>(answer.Id, resource, control, callback);
        }

        /// <summary>
        /// Saves the answer to the database
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void save(PredefinedAnswer answer, Control control, Action<PredefinedAnswer> callback)
        {
            this.save<PredefinedAnswer>(this.getFields(answer), resource, control, callback);
        }

        /// <summary>
        /// Finds an instance of the answer model by id
        /// </summary>
        /// <param name="id">The ID of the instance</param>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void findById(int id, Control control, Action<PredefinedAnswer> callback)
        {
            this.findById<PredefinedAnswer>(id, resource, control, callback);
        }

        /// <summary>
        /// Finds all instances of the answer model
        /// </summary>
        /// <param name="control">The control of the thread which the callback will be called on</param>
        /// <param name="callback">The callback will be executed when the request completes</param>
        public void findAll(Control control, Action<List<PredefinedAnswer>> callback)
        {
            this.findAll<PredefinedAnswer>(resource, control, callback);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Prepares the entity to save it
        /// </summary>
        /// <param name="answer">The answer to save</param>
        /// <returns>Dictonary containing the values used to save the entity</returns>
        private Dictionary<string, object> getFields(PredefinedAnswer answer)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("Text", answer.Text);
            values.Add("Question_Id", answer.Question_Id);
            values.Add("Right_Answer", answer.RightAnswer);
            return values;
        }
        #endregion
    }
}
