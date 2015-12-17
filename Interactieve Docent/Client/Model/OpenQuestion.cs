using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class OpenQuestion : AbstractModel
    {
        public override int Id { get; set; }
        public string Text { get; set; }
        public string Pincode_Id { get; set; }

        public OpenQuestion(Dictionary<string, object> data)
        {
            this.Id = Convert.ToInt32(data["Id"]);
            this.Text = Convert.ToString(data["Text"]);
            this.Pincode_Id = (string)data["Pincode_Id"];
        }

        public OpenQuestion() { }

        public override string ToString()
        {
            return Text;
        }
    }
}

