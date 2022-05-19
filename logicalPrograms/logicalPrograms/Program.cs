
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 1 to run fibonacciSeries");
Console.WriteLine("Enter 2 to run perfectNumber");
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
}

