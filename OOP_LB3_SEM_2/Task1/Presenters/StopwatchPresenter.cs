using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Task1.Interfaces;

namespace Task1.Presenters
{
    class StopwatchPresenter:IStopwatchPresenter
    {
        private StopwatchModel Model;
        private MainWindow main;

        public StopwatchPresenter(MainWindow main)
        {
            this.main = main;
            this.Model = new StopwatchModel();

            this.main.TimeBlock.Text = Model.Stopwatch.Time.ToString("HH:mm:ss");

            #region Events
            Model.Stopwatch.Timer.Tick += Timer_Tick;
            main.Start.Click += Start_Click;
            main.Pause.Click += Pause_Click;
            main.Stop.Click += Stop_Click;
            #endregion

        }

        #region Events

        public void Timer_Tick(object sender, EventArgs e)
        {
            Model.Stopwatch.Time = Model.Stopwatch.Time.AddSeconds(1);
            main.TimeBlock.Text = Model.Stopwatch.Time.ToString("HH:mm:ss");
        }
        
        public void Pause_Click(object sender, RoutedEventArgs e)
        {
            Model.Pause();
        }

        public void Stop_Click(object sender, RoutedEventArgs e)
        {
            Model.Stop();
            main.TimeBlock.Text = Model.Stopwatch.Time.ToString("HH:mm:ss");
        }

        public void Start_Click(object sender, RoutedEventArgs e)
        {
            Model.Start();
        }
        #endregion
    }
}
