using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace FarmMonitor
{
    public class Tabs : ObservableCollection<Tab>
    {
        //public List<Tab> TabList { get; set; }
        //public bool Active { get; set; }
        
        public Tabs()
        {
            this.Add(new Tab());
        }

        public void AddTab()
        {
            //TabList.Add(new Tab());
            this.Add(new Tab());
        }

        
        
    }
}
