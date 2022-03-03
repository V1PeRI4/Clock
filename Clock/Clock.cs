using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Clock
    {
        public void ParseTime(int sec)
        {
            Console.Clear();

            if (sec % 3600 == 0)
                Console.WriteLine("Прошел час");
            else if (sec % 60 == 0)
                Console.WriteLine("Прошла минута");
            else
                Console.WriteLine(sec + " сек");
        }




    }
}
