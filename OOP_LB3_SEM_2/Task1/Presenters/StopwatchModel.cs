using System;
using System.Collections.Generic;
using System.Text;
using Task1.Interfaces;
using Task1.Models;

namespace Task1.Presenters
{
    class StopwatchModel:IStopwatchModel
    {
        public Stopwatch Stopwatch { get; }

        public StopwatchModel()
        {
            Stopwatch = new Stopwatch();
        }

        public void Pause()
        {
            Stopwatch.Timer.IsEnabled = false;
        }

        public void Start()
        {
            Stopwatch.Timer.IsEnabled = true;
        }

        public void Stop()
        {
            Stopwatch.Timer.IsEnabled = false;
            Stopwatch.Time = new DateTime(0, 0);
        }
    }
}
