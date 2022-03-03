using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    internal class Timer
    {
        public delegate void TimeChange(int sec);
        public event TimeChange TimeChangeEvent;

        private int _sec;

        public Timer() { }

        public int Sec { get => _sec; set => _sec = value; }


        public void Start(int sec)
        {
            
            

            while (sec < 10000)
            {
                Thread.Sleep(1000);
                sec++;
                TimeChangeEvent.Invoke(sec);
            }

        }

    }
}
