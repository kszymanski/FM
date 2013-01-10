using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmMonitor
{
    public class Url
    {
        public string Uri { get; set; }
        public List<Result> Results { get; set; }

        public void AddServer(string ip)
        {
            Results = new List<Result>();
            Uri = "asd";
            Results.Add(new Result(ip));
        }
    }
}
