using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Program
    {
        static Timer _timer = new Timer();
        static void Main(string[] args)
        {
            
            Clock clock = new Clock();

            _timer.TimeChangeEvent += clock.ParseTime;

            _timer.Start(0);

            Console.ReadLine();

        }
    }
}
