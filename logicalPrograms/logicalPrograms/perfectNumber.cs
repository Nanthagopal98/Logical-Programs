using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    public class perfectNumber
    {
        public void findPerfectNumber()
        {
            int result = 0;
            Console.WriteLine("Enter number to check for perfect number");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine(i);
                    result = result + i;

                }
            }
            if(result == input)
            {
                Console.WriteLine(input + " is a perfect number");
            }
            else
            {
                Console.WriteLine(input + " is not a perfect number");
            }
        }
    }
}
