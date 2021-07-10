using System;

public class Program
{
    public static void Main()
    {
        double cel, kel;
        Console.WriteLine("Digite o valor em graus Celsius:");
        cel = double.Parse(Console.ReadLine());
        kel = cel + 273;
        Console.WriteLine(kel + " Graus Kelvin");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.ReadKey();
    }
}
