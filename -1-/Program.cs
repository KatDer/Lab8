using System;

namespace aip;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите Х=");
        double x = double.Parse(Console.ReadLine());

        double y = 0;

        if (x < 0.1)
        {
            y = Math.Sqrt(Math.Abs(2*x*x+Math.Sin(x)+1));
        }
        else
            Console.WriteLine("Условие x < 0.1 не выполнилось");

        if (x == 0.1)
        {
            y = Math.Pow(Math.E, x) +2*x;
        }
        else
            Console.WriteLine("Условие x = 0,1 не выполнилось");

        Console.WriteLine("Результат Y={0}", y);

    }
}