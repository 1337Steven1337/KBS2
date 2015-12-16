﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class OpenQuestion : AbstractModel
    {
        public override int Id { get; set; }
        public string Text { get; set; }

        public OpenQuestion(Dictionary<string, object> data)
        {
            this.Id = Convert.ToInt32(data["Id"]);
            this.Text = Convert.ToString(data["Text"]);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}

