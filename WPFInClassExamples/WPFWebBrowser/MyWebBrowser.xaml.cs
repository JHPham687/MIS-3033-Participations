using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFWebBrowser
{
    /// <summary>
    /// Interaction logic for MyWebBrowser.xaml
    /// </summary>
    public partial class MyWebBrowser : Window
    {
        public string query { get; set; }

        public MyWebBrowser()
        {
            InitializeComponent();         
        }

        public void Search(string q)
        {
            query = q;
            webGoogle.Navigate($"https://www.google.com/search?q={query}");
        }
    }
}
