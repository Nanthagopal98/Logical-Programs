using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
 
namespace logicalPrograms
{
    internal class stopWatchTime
    {
        public void timeCalculate()
        {
            Console.WriteLine("Press 1 to start");
            int input = Convert.ToInt32(Console.ReadLine());
            Stopwatch watch = new Stopwatch();
                while (input == 1)
                {
                    watch.Start();
                    Console.WriteLine("Press 2 to stop");
                    int stop = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            watch.Stop();
            Console.WriteLine("Time duration = " + watch.ElapsedMilliseconds + " milliseconds");

        }
    }
}
