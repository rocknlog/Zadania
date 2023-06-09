// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj długość pierwszego boku");
        a = inputValue();
        Console.WriteLine("Podaj długość drugiego boku");
        b = inputValue();
        Console.WriteLine("Podaj długość trzeciego boku");
        c = inputValue();
        if (a == b && b == c)
        {
            Console.WriteLine("Te boki utworzą trójkąt równoboczny");
        }
        else
        {
            Console.WriteLine("Te boki nie utworzą trójkąta równobocznego");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

