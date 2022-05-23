using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class squareRoot
    {
        public void GetRoot()
        {
            Console.WriteLine("Enter Number");
            double number = Convert.ToDouble(Console.ReadLine());
            double answer = number;
            while ((Math.Abs(answer - number / answer)) > (1e-15 * answer))
            {
                answer = (answer + (number / answer)) / 2;
            }
            Console.WriteLine(answer);
        }
    }
}
