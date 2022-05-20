using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class reverseNumber
    {
        public void reverseNum()
        {
            int lastNumber,reverseNumber=0;
            Console.WriteLine("Enter number to reverse");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input = " + input);
            while(input != 0)
            {
                if (input != 0)
                { 
                lastNumber = (input % 10);
                input = (input / 10);
                reverseNumber = (reverseNumber * 10) + lastNumber;
            }
                }
            Console.WriteLine("Reversed input = " + reverseNumber);
        }   
    }
}
