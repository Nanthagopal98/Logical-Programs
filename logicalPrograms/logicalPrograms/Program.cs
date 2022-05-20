
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 1 to run fibonacci Series");
Console.WriteLine("Enter 2 to run perfect Number");
Console.WriteLine("Enter 3 to run prime Number");
Console.WriteLine("Enter 4 to run reverse a Number");
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
}

