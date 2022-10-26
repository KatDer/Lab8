using System;

namespace aip;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите Х= ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите Y= ");

        double y = double.Parse(Console.ReadLine());

        if ((x * x + y * y) < (15 * 15) || (x * x + y * y) > (25 * 25))
        {
            Console.WriteLine("Точка попадает в заштрихованную область");
        }
        else
            Console.WriteLine("Точка не попадает в заштрихованную область");

    }
}