﻿using BLAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PL.WPF
{
    /// <summary>
    /// Interaction logic for TravelerWindow.xaml
    /// </summary>
    public partial class TravelerWindow : Window
    {
        IBL bL;
        BO.BusStation CurBusStation;
       
        
        public TravelerWindow(IBL _bL)
        {
            InitializeComponent();
            bL = _bL;
           
            AllBusStaionsDataGrid.DataContext = bL.GetAllBusStation();
            AllBusStaionsDataGrid.IsReadOnly = true;
            AlllinesDataGrid.IsReadOnly = true;
           

            //timeWorker.WorkerReportsProgress = true;
            //tsStartTime = DateTime.Now.TimeOfDay;
            //Stopwatch.Restart();
            //isTimerRun = true;
            //timeWorker.RunWorkerAsync();
        }
 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SimulateOneStationWindow simulateOneStationWindow = new SimulateOneStationWindow(bL,CurBusStation);

            simulateOneStationWindow.ShowDialog();



        }
        private void AllBusStaionsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurBusStation = AllBusStaionsDataGrid.SelectedItem as BO.BusStation;

            AlllinesDataGrid.DataContext = (CurBusStation).ListBusLinesInStation.ToList();
        }
    }
}
