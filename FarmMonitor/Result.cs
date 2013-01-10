using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmMonitor
{
    public enum state
    {
        Pass, Fail, Warning, Other, NotRun
    }
    public class Result
    {
        public state State { get; set; }
        public bool Active { get; set; }
        public string Server { get; set; }
        public string Comment { get; set; }
        public Result(string ip="none", bool active = true)
        {
            Server = ip;
            Active = active;
            State = state.NotRun;
            Comment = String.Empty;
        }
    }
}
