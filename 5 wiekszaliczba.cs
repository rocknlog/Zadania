﻿// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj a");
        a = inputValue();
        Console.WriteLine("Podaj b");
        b = inputValue();
        if (a == b)
        {
            Console.WriteLine("Liczby są równe");
        }
        else if (a > b) ;
        {
            Console.WriteLine("Większą liczbą jest");
            Console.WriteLine(a);
        }
        else if (a < b) ;
        {
            Console.WriteLine("Większą liczbą jest");
            Console.WriteLine(b);
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
