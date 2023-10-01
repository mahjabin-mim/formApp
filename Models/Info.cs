using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormApp.Models
{
    public class Info
    {
        public string name { set; get; }
        public string id { set; get; }
        public string gender { set; get; }
        public string profession { set; get; }
        public string[] hobbies { set; get; }

       /* public Info(string name,string[]hobbies)
        {
            this.hobbies = hobbies;
        }*/

        public Info()
        {

        }
    }
}