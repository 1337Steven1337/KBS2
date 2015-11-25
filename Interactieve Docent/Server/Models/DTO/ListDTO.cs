using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Models.DTO
{
    public class ListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<QuestionDTO> Questions { get; set;  }

        public ListDTO()
        {

        }
        public ListDTO(List q)
        {
            this.Id = q.Id;
            this.Name = q.Name;
        }
    }
}