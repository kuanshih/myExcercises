using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace prjnothing.Models
{
    public class CStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }   
        public string Address { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public int Grade { get; set; }
    }
}