using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Api.Web_APIs
{

    public class Result
    {
        public string name { get; set; }
        public string price { get; set; }
        public string change { get; set; }
        public string low { get; set; }
        public string High { get; set; }
        public string update { get; set; }

        public string shahr { get; set; }
        public string tarikh { get; set; }
        public string azansobh { get; set; }
        public string toloaftab { get; set; }
        public string azanzohr { get; set; }
        public string ghorubaftab { get; set; }
        public string azanmaghreb { get; set; }
        public string nimeshab { get; set; }
    }

    public class Owghat
    {
        public string shahr { get; set; }
        public string tarikh { get; set; }
        public string azansobh { get; set; }
        public string toloaftab { get; set; }
        public string azanzohr { get; set; }
        public string ghorubaftab { get; set; }
        public string azanmaghreb { get; set; }
        public string nimeshab { get; set; }
    }

    public class Root
    {
        public bool Ok { get; set; }
        public List<Result> Result { get; set; }
    }
}
