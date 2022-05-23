﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class couponNumber
    {
        public void findCouponNumber()
        {
            Console.WriteLine("Enter the number of Distinct Coupon Numbers:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] couponNumbers = new int[number];
            Random value = new Random();
            int totalRandomNumbers = 0;
            for (int i = 0; i < number; i++)
            {
                int arrayChecker = 0;
                int randomCheck = value.Next(10000, 100000);

                for (int j = 0; j < number; j++)
                {

                    if (couponNumbers[j] == randomCheck)
                    {
                        arrayChecker = 1;
                        break;
                    }

                }

                if (arrayChecker != 1)
                {
                    couponNumbers[i] = randomCheck;
                }
                else
                {
                    i--;
                }
                totalRandomNumbers++;
            }
            Console.WriteLine(String.Join(" ", couponNumbers));
            Console.WriteLine();
            Console.WriteLine("Total random number needed to have all distinct numbers:" + totalRandomNumbers);
        }

    }
    
}
