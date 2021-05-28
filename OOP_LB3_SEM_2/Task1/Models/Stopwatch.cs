using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Task1.Models
{
    class Stopwatch
    {
        public Stopwatch()
        {
            Time = new DateTime(0, 0);
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
        }

        public DateTime Time { get; set; }
        public DispatcherTimer Timer { get; set; }
    }
}
