// See https://aka.ms/new-console-template for more information

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double p;

        p = inputValue();
        double r;

        r = Math.Sqrt(p / 3.14);
        double o;

        o = 2 * 3.14 * r;
        Console.WriteLine(o);
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
