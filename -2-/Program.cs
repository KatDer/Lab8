using System;

namespace aip;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите a =");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите b =");

        double b = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите c =");
       
        double c = double.Parse(Console.ReadLine());
     
        if ((b*b - 4*a*c) < 0)
        {
            Console.WriteLine("Уравнение не имеет решений");
        }
        else
            Console.WriteLine("Уравнение имеет решения");


    }
}