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

namespace FarmMonitor
{
    /// <summary>
    /// Interaction logic for tast.xaml
    /// </summary>
    public partial class TabHeader : UserControl
    {
        public TabHeader()
        {
            InitializeComponent();
        }
        public void OnMouseEnter(object sender, MouseEventArgs e)
        {
            button_close.Visibility = Visibility.Visible;
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            button_close.Visibility = Visibility.Hidden;
        }
        private void OnDoubleClick(object sender, MouseEventArgs e)
        {
            label_TabTitle.Visibility = System.Windows.Visibility.Collapsed;
            InputTextBox.Text = label_TabTitle.Content.ToString();
            InputBox.Visibility = System.Windows.Visibility.Visible;
        }

        private void InputTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                label_TabTitle.Visibility = System.Windows.Visibility.Visible;
                InputBox.Visibility = System.Windows.Visibility.Collapsed;
                label_TabTitle.Content = InputTextBox.Text;
            }
            if (e.Key == Key.Escape)
            {
                label_TabTitle.Visibility = System.Windows.Visibility.Visible;
                InputBox.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

    }
}
