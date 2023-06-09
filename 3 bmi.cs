// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h;

        Console.WriteLine("Podaj wagę (kg)");
        w = inputValue();
        Console.WriteLine("Podaj wzrost (m)");
        h = inputValue();
        double bmi;

        bmi = w / (h * h);
        Console.WriteLine("BMI wynosi");
        Console.WriteLine(bmi);
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

