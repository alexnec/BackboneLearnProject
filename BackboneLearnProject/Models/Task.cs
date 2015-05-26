using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackboneLearnProject.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}