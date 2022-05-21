namespace logicalPrograms
{
    internal class monthlyPayment
    {
        public void findMonthlyPay()
        {
            double amount, years, interest,r, monthlyPayment;
            Console.WriteLine("Enter principal loan amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter years to pay");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter percent interest");
            interest = Convert.ToInt32(Console.ReadLine());

            double n = 12 * years;
            r = interest/(12 * 100);
            monthlyPayment = (amount * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine(Math.Round(monthlyPayment, 4));
        }
    }
}
