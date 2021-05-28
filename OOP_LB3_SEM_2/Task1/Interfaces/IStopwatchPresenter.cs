using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Task1.Presenters;

namespace Task1.Interfaces
{
    interface IStopwatchPresenter
    {
        void Pause_Click(object sender, RoutedEventArgs e);
        void Start_Click(object sender, RoutedEventArgs e);
        void Stop_Click(object sender, RoutedEventArgs e);
        void Timer_Tick(object sender, EventArgs e);
    }
}
