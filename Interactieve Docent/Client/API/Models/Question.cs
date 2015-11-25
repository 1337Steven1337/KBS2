﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.API.Models
{
    public class Question : Entity
    {
        private string _text = null;
        private int _time = -1;
        private int _points = -1;
        private int _list_Id = -1;
        private List<PredefinedAnswer> _predefinedAnswers = null;
        private List<UserAnswer> _userAnswers = null;
        private List _list = null;

        public int Id { get; set; }
        public string Text
        {
            get
            {
                if (!this._fetched && this._text == null)
                {
                    this.fetch();
                }

                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        public int Time
        {
            get
            {
                if (!this._fetched && this._time == -1)
                {
                    this.fetch();
                }

                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        public int Points
        {
            get
            {
                if (!this._fetched && this._points == -1)
                {
                    this.fetch();
                }

                return this._points;
            }
            set
            {
                this._points = value;
            }
        }

        public int List_Id
        {
            get
            {
                if(!this._fetched && this._list_Id == -1)
                {
                    this.fetch();
                }

                return this._list_Id;
            }
            set
            {
                this._list_Id = value;
            }
        }

        public List List
        {
            get
            {
                if (!this._fetched && this._list == null)
                {
                    this.fetch();
                }

                return this._list;
            }
            set
            {
                this._list = value;
            }
        }

        public Question()
        {

        }

        public Question(bool shouldFetch = true)
        {
            this._fetched = !shouldFetch;
        }

        public List<PredefinedAnswer> PredefinedAnswers
        {
            get
            {
                if (!this._fetched && this._predefinedAnswers == null)
                {
                    this.fetch();
                }

                return this._predefinedAnswers;
            }
            set
            {
                this._predefinedAnswers = value;
            }
        }

        public List<UserAnswer> UserAnswers
        {
            get
            {
                if (!this._fetched && this._userAnswers == null)
                {
                    this.fetch();
                }

                return this._userAnswers;
            }
            set
            {
                this._userAnswers = value;
            }
        }

        public void save()
        {
            RestRequest request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("Text", this.Text);
            request.AddParameter("Time", this.Time);
            request.AddParameter("Points", this.Points);
            request.AddParameter("List_Id", this.List.Id);
            request.Resource = "Questions";

            List q = Api.Execute<List>(request);
            this.Id = q.Id;
        }

        public void delete()
        {
            RestRequest request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("Id", this.Id);
            request.Resource = "Questions";

            List q = Api.Execute<List>(request);
            this.Id = q.Id;
        }

        public static Question getById(int id)
        {
            return Question.getById<Question>(id, "Questions");
        }

        public static List<Question> getAll()
        {
            return Question.getAll<Question>("Questions");
        }

        protected override void fetch()
        {
            this._fetched = true;
            Question q = Question.getById(this.Id);
            this.copyValues<Question>(this, q);
        }
    }
}