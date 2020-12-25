using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BPT_Service
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string gender { get; set; }
        public int bloodPressure { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}