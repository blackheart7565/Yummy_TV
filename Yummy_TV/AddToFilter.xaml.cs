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
using System.Windows.Shapes;

namespace Yummy_TV
{
    /// <summary>
    /// Interaction logic for AddToFilter.xaml
    /// </summary>
    public partial class AddToFilter : Window
    {
        public AddToFilter()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}