using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackboneLearnProject.Models
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string CodeName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}