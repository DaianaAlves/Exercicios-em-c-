using System;

public class Program
{
    public static void Main()
    {
        double kg, gramas, porc1, porc2;
        Console.WriteLine("Digite o valor de seu peso em KG :");
        kg = double.Parse(Console.ReadLine());
        gramas = kg * 1000;
        porc1 = kg * 1.10;
        porc2 = = gramas * 1.10;
        Console.WriteLine("Você possui " + gramas + " gramas");
        Console.WriteLine("Você irá ficar com " + porc2 + " gramas,caso ganhe mais 10%");
        Console.WriteLine("Você irá ficar com " + porc1 + Kgs, caso ganhe mais 10 % ");

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.ReadKey();
    }
}
