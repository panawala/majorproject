﻿using System;
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
using System.Windows.Shapes;

namespace WpfApplication3.ResourcesAndManpower
{
    /// <summary>
    /// Interaction logic for WindowHuman.xaml
    /// </summary>
    public partial class WindowHuman : Window
    {
        public WindowHuman()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Touxiang.Source= new BitmapImage(new Uri("/Images/yusuan.png", UriKind.Relative));
        }
    }
}
