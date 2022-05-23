// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 1 to run fibonacci Series");
Console.WriteLine("Enter 2 to run perfect Number");
Console.WriteLine("Enter 3 to run prime Number");
Console.WriteLine("Enter 4 to run reverse a Number");
Console.WriteLine("Enter 5 to run Coupon Number");
Console.WriteLine("Enter 6 to run stop Watch");
Console.WriteLine("Enter 7 to run Vending Machine");
Console.WriteLine("Enter 8 to run Temperature Conversion");
Console.WriteLine("Enter 9 to run monthly Payment");
Console.WriteLine("Enter 10 to run Days Of Week");
Console.WriteLine("Enter 11 to run Square Root");
Console.WriteLine("Enter 12 to run Convert To Binary");
int run =Convert.ToInt32(Console.ReadLine());
switch (run)
{
    case 1:
        logicalPrograms.fibonacciSeries run1 = new logicalPrograms.fibonacciSeries();
        run1.fibonacci();
        break;
    case 2:
        logicalPrograms.perfectNumber run2 = new logicalPrograms.perfectNumber();
        run2.findPerfectNumber();
        break;
    case 3:
        logicalPrograms.primeNumber run3 = new logicalPrograms.primeNumber();
        run3.findPrimeNumber();
        break;
    case 4:
        logicalPrograms.reverseNumber run4 = new logicalPrograms.reverseNumber();
        run4.reverseNum();
        break;
    case 5:
        logicalPrograms.couponNumber run5 = new logicalPrograms.couponNumber();
        run5.findCouponNumber();
        break;
    case 6:
        logicalPrograms.stopWatchTime run6 = new logicalPrograms.stopWatchTime();
        run6.timeCalculate();
        break;
    case 7:
        logicalPrograms.vendingMachine run7 = new logicalPrograms.vendingMachine();
        run7.checkBalance();
        break;
    case 8:
        logicalPrograms.temperatureConversion run8 = new logicalPrograms.temperatureConversion();
        run8.convertTemperature();
        break;
    case 9:
        logicalPrograms.monthlyPayment run9 = new logicalPrograms.monthlyPayment();
        run9.findMonthlyPay();
        break;
    case 10:
        logicalPrograms.daysOfWeek run10 = new logicalPrograms.daysOfWeek();
        run10.findDaysOfWeek();
        break;
    case 11:
        logicalPrograms.squareRoot run11 = new logicalPrograms.squareRoot();
        run11.GetRoot();
        break;
    case 12:
        logicalPrograms.convertToBinary run12 = new logicalPrograms.convertToBinary();
        run12.GetBinary();
        break;


}


