using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    public class primeNumber
    {
        public void findPrimeNumber()
        {
            int count = 0;
            Console.WriteLine("Enter number to check for prime number");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(input + "is not a prime number");
            }
            else
            {
                Console.WriteLine(input + "is a prime number");
            }
        }
    }
}