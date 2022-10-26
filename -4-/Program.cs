using System;

namespace aip;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число :");
        string x = Console.ReadLine();
        int len = x.Length;
        bool flag = true;

        for (int i = 0; i < len / 2; i++)
        {
            if (x[i] != x[len - (i + 1)])
            {
                flag = false;
                break;
            }
        }

        if (flag)
        {
            Console.WriteLine("Заданное число является палиндромом ");
        }
        else
        {
            Console.WriteLine("Заданное число не является палиндромом ");
        }
        Console.ReadLine();

    }
}