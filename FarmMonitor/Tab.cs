using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;

namespace FarmMonitor
{
    public class Tab :  INotifyPropertyChanged 
    {
        
        public DataGrid Grid { get; set; }
        public List<Url> PageList { get; set; }
        public TabHeader closableTabHeader {set; get;}
        
        public Tab()
        {
            
            closableTabHeader = new TabHeader();
            closableTabHeader.label_TabTitle.Content = "Write Title";
            closableTabHeader.button_close.AddHandler(Button.ClickEvent, new RoutedEventHandler(button_close_Click));
            PageList = new List<Url>();
            
            Grid = new DataGrid();
            Grid.AutoGenerateColumns = false;
            Grid.ItemsSource = PageList;
            
            DataGridTextColumn dataColumn = new DataGridTextColumn();
            dataColumn.Header = "HeaderName1";
            //Binding bindObj = new Binding("Results[0].Server");
            Binding bindObj = new Binding("Uri");
            dataColumn.Binding = bindObj;
            Grid.Columns.Add(dataColumn);
            
        }

        public void button_close_Click(object sender, RoutedEventArgs e)
        {
            //close tab
           
        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string pName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(pName));
        }

        #endregion
    }
}
