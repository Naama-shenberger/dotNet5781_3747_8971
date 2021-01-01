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
using BLAPI;

namespace PL.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IBL bl = BLFactory.GetBL("1");
        public MainWindow()
        {
            InitializeComponent();
          
        }
        private void btnGO_Click(object sender, RoutedEventArgs e)
        {
            if (rbBus.IsChecked == true)
            {
                new BusWindow(bl).Show();
                Close();
            }
            else if(rbBusLine.IsChecked==true)
            {
                new BusLineWindow(bl).Show();
                Close();
            }
            else
            {
                new StationWindow(bl).Show();
                Close();
            }
        }
    }
}
