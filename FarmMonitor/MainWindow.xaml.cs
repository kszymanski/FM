using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FarmMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Tabs TabControl;
        public MainWindow()
        {
            InitializeComponent();
            // Set the ItemsSource of the TabControl
            // to the collection of Tab list.
            TabControl = new Tabs();
            TabControl.AddTab();
            _myTabControl.ItemsSource = TabControl;

        }

        private void TabItemMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TabControl.AddTab();
        }

        private void asd(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
