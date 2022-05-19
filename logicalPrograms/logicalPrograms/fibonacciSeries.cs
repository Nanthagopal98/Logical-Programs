using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    public class fibonacciSeries
    {
        public void fibonacci()
        {
            int x=0, y=1,z,temp2;
            Console.WriteLine("Enter value to find Fibonacci series");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series of "+input+" values");
            for (int i = 0; i < input; i++)
            {
                z = x + y;
                x = y; 
                y = z;
                Console.WriteLine(z);

            }
        }
    }
}
