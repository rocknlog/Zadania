// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r;

        Console.WriteLine("Podaj współrzędną x");
        x = inputValue();
        Console.WriteLine("Podaj współrzędną y");
        y = inputValue();
        Console.WriteLine("Podaj promień koła");
        r = inputValue();
        if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(r, 2))
        {
            Console.WriteLine("Ten punkt leży w obrębie koła");
        }
        else
        {
            Console.WriteLine("Ten punkt nie leży w obrębie koła");
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

