﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            EntryForm newEntry = new EntryForm()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                ZipCode = Convert.ToInt32(txtZip.Text)
            };

            lstApps.Items.Add(newEntry);
        }

        private void lstApps_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
