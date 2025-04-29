using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int number = 0;
        int iterations = 0;

        while (number < 100)
        {
            number ++;
            Console.WriteLine(number);
            iterations = iterations + 1;
            if (iterations > 1005)
            {
                break;
            }
        }

    }
}