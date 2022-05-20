using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class vendingMachine
    {
        public void checkBalance()
        {
            int remaining=0;
            Console.WriteLine("Enter number rupees");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input >= 1000 )
            {
                remaining = input % 1000;
                int thousandCount = input/1000;
                Console.WriteLine("Thousand rupees = " + thousandCount);
                input = remaining;
            }
            if (input >=500 || remaining >=500)
            {
                remaining = input % 500;
                int fivehundredCount = input / 500;
                Console.WriteLine("Five Hundred rupees = " + fivehundredCount);
                input = remaining;
            }
            if (input >= 100 || remaining >= 100)
            {
                remaining = input % 100;
                int hundredCount = input / 100;
                Console.WriteLine("Hundred rupees = " + hundredCount);
                input = remaining;
            }
            if (input >= 50 || remaining >= 50)
            {
                remaining = input % 50;
                int fiftyCount = input / 50;
                Console.WriteLine("Fifty rupees = " + fiftyCount);
                input = remaining;
            }
            if (input >= 10 || remaining >= 10)
            {
                remaining = input % 10;
                int tenCount = input / 10;
                Console.WriteLine("Tens rupees = " + tenCount);
                input = remaining;
            }
            if (input >= 5 || remaining >= 5)
            {
                remaining = input % 5;
                int fiveCount = input / 5;
                Console.WriteLine("five rupees = " + fiveCount);
                input = remaining;
            }
            if (input >= 2 || remaining >= 2)
            {
                remaining = input % 2;
                int twoCount = input / 2;
                Console.WriteLine("Two rupees = " + twoCount);
                input = remaining;
            }
            Console.WriteLine("one rupees = " + input);

        }
    }
}
