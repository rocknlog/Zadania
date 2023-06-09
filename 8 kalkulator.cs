// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj pierwszą liczbę");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        b = inputValue();
        Console.WriteLine("Wybierz numer działania: 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");
        double działanie;

        działanie = inputValue();
        if (działanie == 1)
        {
            Console.WriteLine(a + b);
        }
        if (działanie == 2)
        {
            Console.WriteLine(a - b);
        }
        if (działanie == 3)
        {
            Console.WriteLine(a * b);
        }
        if (działanie == 4)
            if (b == 0)
                    Console.WriteLine(a + "/0");
        else
        {
            Console.WriteLine(a / b);
        }
        if (działanie > 4)
        {
            Console.WriteLine("Zły numer działania");
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

