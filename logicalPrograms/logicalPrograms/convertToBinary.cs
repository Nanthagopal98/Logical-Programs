namespace logicalPrograms
{
    internal class convertToBinary
    {
        public void GetBinary()
        {
            Console.WriteLine("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> binaryList = new List<int>();
            int power2 = 2;
            while (number > power2)
            {
                power2 *= 2;
            }

            while (power2 > 0)
            {
                if (number >= power2)
                {
                    number -= power2;
                    binaryList.Add(1);
                }
                else
                {
                    binaryList.Add(0);
                }
                power2 /= 2;
            }

            Console.WriteLine(string.Join(" ", binaryList));
        }
    }
}
